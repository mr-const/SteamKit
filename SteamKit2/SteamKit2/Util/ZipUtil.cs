/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */



using System;
using System.Buffers;
using System.IO;
using System.IO.Compression;
using System.IO.Hashing;

namespace SteamKit2
{
    static class ZipUtil
    {
        public static int Decompress( MemoryStream ms, byte[] destination, bool verifyChecksum = true )
        {
            using var zip = new ZipArchive( ms );
            var entries = zip.Entries;

            DebugLog.Assert( entries.Count == 1, nameof( ZipUtil ), "Expected the zip to contain only one file" );

            var entry = entries[ 0 ];
            var sizeDecompressed = ( int )entry.Length;

            if ( destination.Length < sizeDecompressed )
            {
                throw new ArgumentException( "The destination buffer is smaller than the decompressed data size.", nameof( destination ) );
            }

            using var entryStream = entry.Open();

            entryStream.ReadExactly( destination, 0, sizeDecompressed );

            if ( verifyChecksum && Crc32.HashToUInt32( destination.AsSpan()[ ..sizeDecompressed ] ) != entry.Crc32 )
            {
                throw new Exception( "Checksum validation failed for decompressed file" );
            }

            return sizeDecompressed;
        }

        public static ArraySegment<byte> Decompress( ReadOnlySpan<byte> buffer, bool verifyChecksum = true )
        {
            using var ms = new MemoryStream( buffer.ToArray() );
            using var zip = new ZipArchive( ms );
            var entries = zip.Entries;

            DebugLog.Assert( entries.Count == 1, nameof( ZipUtil ), "Expected the zip to contain only one file" );

            var entry = entries[ 0 ];
            var sizeDecompressed = ( int )entry.Length;

            ArraySegment<byte> destination = new ArraySegment<byte>(
                ArrayPool<byte>.Shared.Rent( ( int )sizeDecompressed ),
                0,
                ( int )sizeDecompressed
            );

            using var entryStream = entry.Open();

            entryStream.ReadExactly( destination.Array!, 0, sizeDecompressed );

            if ( verifyChecksum && Crc32.HashToUInt32( destination.AsSpan()[ ..sizeDecompressed ] ) != entry.Crc32 )
            {
                throw new Exception( "Checksum validation failed for decompressed file" );
            }

            return destination;
        }
    }
}
