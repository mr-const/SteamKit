/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */



using System;
using System.Buffers;
using System.IO;
using System.IO.Compression;
using System.IO.Hashing;
using System.Text;

namespace SteamKit2
{
    static class ZipUtil
    {
        private static uint LocalFileHeader = 0x04034b50;
        private static uint CentralDirectoryHeader = 0x02014b50;
        private static uint EndOfDirectoryHeader = 0x06054b50;

        private static ushort DeflateCompression = 8;
        private static ushort StoreCompression = 0;

        private static ushort Version = 20;

        /// <summary>
        /// Accepts a buffer containing a zip file and returns the decompressed data. Releases input buffer and allocates output buffer using ArrayPool.
        /// Receiver is responsible for releasing the output buffer.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ArraySegment<byte> Decompress( ArraySegment<byte> input )
        {
            using MemoryStream ms = new MemoryStream( input.Array!, input.Offset, input.Count, false, true );
            using BinaryReader reader = new BinaryReader( ms );
            if ( !PeekHeader( reader, LocalFileHeader ) )
            {
                throw new Exception( "Expecting LocalFileHeader at start of stream" );
            }

            string fileName;
            uint decompressedSize;
            ushort compressionMethod;
            uint crc;
            ReadLocalFile( reader, out fileName, out decompressedSize, out compressionMethod, out crc, out ArraySegment<byte> compressedBuffer );

            if ( !PeekHeader( reader, CentralDirectoryHeader ) )
            {
                throw new Exception( "Expecting CentralDirectoryHeader following filename" );
            }

            string cdrFileName;
            /*Int32 relativeOffset =*/ ReadCentralDirectory( reader, out cdrFileName );

            if ( !PeekHeader( reader, EndOfDirectoryHeader ) )
            {
                throw new Exception( "Expecting EndOfDirectoryHeader following CentralDirectoryHeader" );
            }

            /*UInt32 count =*/ ReadEndOfDirectory( reader );

            ArraySegment<byte> decompressed;

            if ( compressionMethod == DeflateCompression )
            {
                decompressed = InflateBuffer( compressedBuffer, decompressedSize );
                ArrayPool<byte>.Shared.Return( input.Array! );
            }
            else
                // in fact we return input array as an output without releasing it here.
                decompressed = compressedBuffer;

            uint checkSum = Crc32.HashToUInt32( decompressed );

            if ( checkSum != crc )
            {
                throw new Exception( "Checksum validation failed for decompressed file" );
            }

            return decompressed;
        }

        public static byte[] Compress( byte[] buffer )
        {
            using MemoryStream ms = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter( ms );
            uint checkSum = Crc32.HashToUInt32( buffer );

            byte[] compressed = DeflateBuffer( buffer );

            int poslocal = WriteHeader( writer, LocalFileHeader );
            WriteLocalFile( writer, "z", checkSum, ( uint )buffer.Length, compressed );

            int posCDR = WriteHeader( writer, CentralDirectoryHeader );
            uint CDRSize = WriteCentralDirectory( writer, "z", checkSum, ( uint )compressed.Length, ( uint )buffer.Length, poslocal );

            /*Int32 posEOD =*/ WriteHeader( writer, EndOfDirectoryHeader );
            WriteEndOfDirectory( writer, 1, CDRSize, posCDR );

            return ms.ToArray();
        }


        private static int WriteHeader( BinaryWriter writer, uint header )
        {
            int position = ( int )writer.BaseStream.Position;

            writer.Write( header );

            return position;
        }

        private static void WriteEndOfDirectory( BinaryWriter writer, uint count, uint CDRSize, int CDROffset )
        {
            writer.Write( ( ushort )0 ); // diskNumber
            writer.Write( ( ushort )0 ); // CDRDisk
            writer.Write( ( ushort )count ); // CDRCount
            writer.Write( ( ushort )1 ); // CDRTotal

            writer.Write( ( uint )CDRSize ); // CDRSize
            writer.Write( ( int )CDROffset ); // CDROffset

            writer.Write( ( ushort )0 ); // commentLength
        }

        private static uint WriteCentralDirectory( BinaryWriter writer, string fileName, uint CRC, uint compressedSize, uint decompressedSize, int localHeaderOffset )
        {
            uint pos = ( uint )writer.BaseStream.Position;

            writer.Write( Version ); // versionGenerator
            writer.Write( Version ); // versionExtract
            writer.Write( ( ushort )0 ); // bitflags
            writer.Write( DeflateCompression ); // compression

            writer.Write( ( ushort )0 ); // modTime
            writer.Write( ( ushort )0 ); // createTime
            writer.Write( CRC ); // CRC

            writer.Write( compressedSize ); // compressedSize
            writer.Write( decompressedSize ); // decompressedSize

            writer.Write( ( ushort )Encoding.UTF8.GetByteCount( fileName ) ); // nameLength
            writer.Write( ( ushort )0 ); // fieldLength
            writer.Write( ( ushort )0 ); // commentLength

            writer.Write( ( ushort )0 ); // diskNumber
            writer.Write( ( ushort )1 ); // internalAttributes
            writer.Write( ( uint )32 ); // externalAttributes

            writer.Write( localHeaderOffset ); // relativeOffset

            writer.Write( Encoding.UTF8.GetBytes( fileName ) ); // filename

            return ( ( uint )writer.BaseStream.Position - pos ) + 4;
        }

        private static void WriteLocalFile( BinaryWriter writer, string fileName, uint CRC, uint decompressedSize, byte[] processedBuffer )
        {
            writer.Write( Version ); // version
            writer.Write( ( ushort )0 ); // bitflags
            writer.Write( DeflateCompression ); // compression

            writer.Write( ( ushort )0 ); // modTime
            writer.Write( ( ushort )0 ); // createTime
            writer.Write( CRC ); // CRC

            writer.Write( processedBuffer.Length ); // compressedSize
            writer.Write( decompressedSize ); // decompressedSize

            writer.Write( ( ushort )Encoding.UTF8.GetByteCount( fileName ) ); // nameLength
            writer.Write( ( ushort )0 ); // fieldLength

            writer.Write( Encoding.UTF8.GetBytes( fileName ) ); // filename
            writer.Write( processedBuffer ); // contents
        }


        private static bool PeekHeader( BinaryReader reader, uint expecting )
        {
            uint header = reader.ReadUInt32();

            return header == expecting;
        }

        private static uint ReadEndOfDirectory( BinaryReader reader )
        {
            /*UInt16 diskNumber =*/ reader.ReadUInt16();
            /*UInt16 CDRDisk =*/ reader.ReadUInt16();
            ushort CDRCount = reader.ReadUInt16();
            /*UInt16 CDRTotal =*/ reader.ReadUInt16();

            /*UInt32 CDRSize =*/ reader.ReadUInt32();
            /*Int32 CDROffset =*/ reader.ReadInt32();

            ushort commentLength = reader.ReadUInt16();
            /*byte[] comment =*/ reader.ReadBytes( commentLength );

            return CDRCount;
        }

        private static int ReadCentralDirectory( BinaryReader reader, out string fileName )
        {
            /*UInt16 versionGenerator =*/ reader.ReadUInt16();
            /*UInt16 versionExtract =*/ reader.ReadUInt16();
            /*UInt16 bitflags =*/ reader.ReadUInt16();
            ushort compression = reader.ReadUInt16();

            if ( compression != DeflateCompression && compression != StoreCompression )
            {
                throw new Exception( "Invalid compression method " + compression );
            }

            /*UInt16 modtime =*/ reader.ReadUInt16();
            /*UInt16 createtime =*/ reader.ReadUInt16();
            /*UInt32 crc =*/ reader.ReadUInt32();

            /*UInt32 compressedSize =*/ reader.ReadUInt32();
            /*UInt32 decompressedSize =*/ reader.ReadUInt32();

            ushort nameLength = reader.ReadUInt16();
            ushort fieldLength = reader.ReadUInt16();
            ushort commentLength = reader.ReadUInt16();

            /*UInt16 diskNumber =*/ reader.ReadUInt16();
            /*UInt16 internalAttributes =*/ reader.ReadUInt16();
            /*UInt32 externalAttributes =*/ reader.ReadUInt32();

            int relativeOffset = reader.ReadInt32();

            byte[] name = reader.ReadBytes( nameLength );
            /*byte[] fields =*/ reader.ReadBytes( fieldLength );
            /*byte[] comment =*/ reader.ReadBytes( commentLength );

            fileName = Encoding.UTF8.GetString( name );
            return relativeOffset;
        }

        private static void ReadLocalFile( BinaryReader reader, out string fileName, out uint decompressedSize, out ushort compressionMethod, out uint crc, out ArraySegment<byte> compressedBuffer )
        {
            /*UInt16 version =*/ reader.ReadUInt16();
            /*UInt16 bitflags =*/ reader.ReadUInt16();
            compressionMethod = reader.ReadUInt16();

            if ( compressionMethod != DeflateCompression && compressionMethod != StoreCompression )
            {
                throw new Exception( "Invalid compression method " + compressionMethod );
            }

            /*UInt16 modtime =*/ reader.ReadUInt16();
            /*UInt16 createtime =*/ reader.ReadUInt16();
            crc = reader.ReadUInt32();

            uint compressedSize = reader.ReadUInt32();
            decompressedSize = reader.ReadUInt32();

            ushort nameLength = reader.ReadUInt16();
            ushort fieldLength = reader.ReadUInt16();

            byte[] name = reader.ReadBytes( nameLength );
            /*byte[] fields =*/ reader.ReadBytes( fieldLength );

            fileName = Encoding.UTF8.GetString( name );

            // reuse input array as output buffer, because we're responsible for releasing it
            compressedBuffer = new ArraySegment<byte>( ( ( MemoryStream )reader.BaseStream ).GetBuffer(), ( int )reader.BaseStream.Position, ( int )compressedSize );
            
            // skip over the compressed data
            reader.ReadBytes( ( int )compressedSize );
        }


        private static ArraySegment<byte> InflateBuffer( ArraySegment<byte> compressedBuffer, uint decompressedSize )
        {
            using MemoryStream ms = new MemoryStream( compressedBuffer.Array!, compressedBuffer.Offset, compressedBuffer.Count );
            using DeflateStream deflateStream = new DeflateStream( ms, CompressionMode.Decompress );
            ArraySegment<byte> inflatedSegment = new ArraySegment<byte>( 
                ArrayPool<byte>.Shared.Rent( ( int )decompressedSize ), 
                0, 
                (int)decompressedSize );

            deflateStream.ReadAll( inflatedSegment );

            ArrayPool<byte>.Shared.Return( compressedBuffer.Array! );
            return inflatedSegment;
        }

        private static byte[] DeflateBuffer( byte[] uncompressedBuffer )
        {
            using MemoryStream ms = new MemoryStream();
            using ( DeflateStream deflateStream = new DeflateStream( ms, CompressionMode.Compress ) )
            {
                deflateStream.Write( uncompressedBuffer, 0, uncompressedBuffer.Length );
            }

            return ms.ToArray();
        }

    }
}
