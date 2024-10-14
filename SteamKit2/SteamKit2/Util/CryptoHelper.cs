/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */



using System;
using System.Buffers;
using System.IO;
using System.Security.Cryptography;

namespace SteamKit2
{
    /// <summary>
    /// Provides Crypto functions used in Steam protocols
    /// </summary>
    public static class CryptoHelper
    {
        /// <summary>
        /// Decrypts using AES/CBC/PKCS7 with an input byte array and key, using the random IV prepended using AES/ECB/None
        /// </summary>
        public static ArraySegment<byte> SymmetricDecrypt( ReadOnlySpan<byte> input, byte[] key)
        {
            ArgumentNullException.ThrowIfNull( key );

            DebugLog.Assert( key.Length == 32, nameof( CryptoHelper ), $"{nameof( SymmetricDecrypt )} used with non 32 byte key!" );

            using var aes = Aes.Create();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = key;

            // first 16 bytes of input is the ECB encrypted IV
            Span<byte> iv = stackalloc byte[ 16 ];
            aes.DecryptEcb( input[ ..iv.Length ], iv, PaddingMode.None );
            
            byte[] decrypted = aes.DecryptCbc( input[ iv.Length.. ], iv, PaddingMode.PKCS7 );
            byte[] buffer = ArrayPool<byte>.Shared.Rent( decrypted.Length );
            Array.Copy(decrypted, buffer, decrypted.Length);

            return new ArraySegment<byte>( buffer, 0, decrypted.Length );
        }
    }
}
