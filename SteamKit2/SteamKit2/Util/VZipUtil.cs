using System;
using System.Buffers.Binary;
using System.IO;
using System.IO.Hashing;

namespace SteamKit2
{
    class VZipUtil
    {
        private static ushort VZipHeader = 0x5A56;
        private static ushort VZipFooter = 0x767A;
        private static int HeaderLength = 7;
        private static int FooterLength = 10;

        private static char Version = 'a';


        public static byte[] Decompress(ReadOnlySpan<byte> buffer)
        {
            if ( BinaryPrimitives.ReadUInt16LittleEndian(buffer.Slice(0)) != VZipHeader )
            {
                throw new Exception( "Expecting VZipHeader at start of stream" );
            }

            if ( buffer[2] != Version )
            {
                throw new Exception( "Expecting VZip version 'a'" );
            }

            // Sometimes this is a creation timestamp (e.g. for Steam Client VZips).
            // Sometimes this is a CRC32 (e.g. for depot chunks).
            /* uint creationTimestampOrSecondaryCRC = reader.ReadUInt32(); */ // skip 4 bytes

            int offset = 7;
            ReadOnlySpan<byte> properties = buffer.Slice(offset, 5);
            offset += properties.Length;
            ReadOnlySpan<byte> compressedBuffer = buffer.Slice(offset, ( int )buffer.Length - HeaderLength - FooterLength - 5 );
            offset += compressedBuffer.Length;

            uint outputCRC = BinaryPrimitives.ReadUInt32LittleEndian(buffer.Slice(offset));
            offset += 4;

            uint sizeDecompressed = BinaryPrimitives.ReadUInt32LittleEndian(buffer.Slice(offset));
            offset += 4;

            if ( BinaryPrimitives.ReadUInt16LittleEndian(buffer.Slice(offset)) != VZipFooter )
            {
                throw new Exception( "Expecting VZipFooter at end of stream" );
            }

            SevenZip.Compression.LZMA.Decoder decoder = new SevenZip.Compression.LZMA.Decoder();
            decoder.SetDecoderProperties( properties );

            using MemoryStream inputStream = new MemoryStream( compressedBuffer.ToArray() );
            using MemoryStream outStream = new MemoryStream( ( int )sizeDecompressed );
            decoder.Code( inputStream, outStream, compressedBuffer.Length, sizeDecompressed, null );

            var outData = outStream.ToArray();
            if ( Crc32.HashToUInt32( outData ) != outputCRC )
            {
                throw new InvalidDataException( "CRC does not match decompressed data. VZip data may be corrupted." );
            }

            return outData;
        }

        public static byte[] Compress(byte[] buffer)
        {
            using MemoryStream ms = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter( ms );
            byte[] crc = Crc32.Hash( buffer );

            writer.Write( VZipHeader );
            writer.Write( ( byte )Version );
            writer.Write( crc );

            int dictionary = 1 << 23;
            int posStateBits = 2;
            int litContextBits = 3;
            int litPosBits = 0;
            int algorithm = 2;
            int numFastBytes = 128;

            SevenZip.CoderPropID[] propIDs =
            [
                SevenZip.CoderPropID.DictionarySize,
                SevenZip.CoderPropID.PosStateBits,
                SevenZip.CoderPropID.LitContextBits,
                SevenZip.CoderPropID.LitPosBits,
                SevenZip.CoderPropID.Algorithm,
                SevenZip.CoderPropID.NumFastBytes,
                SevenZip.CoderPropID.MatchFinder,
                SevenZip.CoderPropID.EndMarker
            ];

            object[] properties =
            [
                dictionary,
                posStateBits,
                litContextBits,
                litPosBits,
                algorithm,
                numFastBytes,
                "bt4",
                false
            ];

            SevenZip.Compression.LZMA.Encoder encoder = new SevenZip.Compression.LZMA.Encoder();
            encoder.SetCoderProperties( propIDs, properties );
            encoder.WriteCoderProperties( ms );

            using ( MemoryStream input = new MemoryStream( buffer ) )
            {
                encoder.Code( input, ms, -1, -1, null );
            }

            writer.Write( crc );
            writer.Write( ( uint )buffer.Length );
            writer.Write( VZipFooter );

            return ms.ToArray();
        }
    }
}
