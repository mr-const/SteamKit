﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */

using System;
using System.Buffers;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SteamKit2.CDN
{
    /// <summary>
    /// The <see cref="Client"/> class is used for downloading game content from the Steam servers.
    /// </summary>
    public sealed class Client : IDisposable
    {
        HttpClient httpClient;

        /// <summary>
        /// Default timeout to use when making requests
        /// </summary>
        public static TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds( 10 );
        /// <summary>
        /// Default timeout to use when reading the response body
        /// </summary>
        public static TimeSpan ResponseBodyTimeout { get; set; } = TimeSpan.FromSeconds( 60 );


        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="httpClient">
        /// The <see cref="HttpClient"/> this instance will be associated with.
        /// The HttpClient instance must be connected and logged onto Steam.</param>
        public Client( HttpClient httpClient )
        {
            ArgumentNullException.ThrowIfNull( httpClient );

            this.httpClient = httpClient;
        }

        /// <summary>
        /// Disposes of this object.
        /// </summary>
        public void Dispose()
        {
            httpClient.Dispose();
        }

        /// <summary>
        /// Downloads the depot manifest specified by the given manifest ID, and optionally decrypts the manifest's filenames if the depot decryption key has been provided.
        /// </summary>
        /// <param name="depotId">The id of the depot being accessed.</param>
        /// <param name="manifestId">The unique identifier of the manifest to be downloaded.</param>
        /// <param name="manifestRequestCode">The manifest request code for the manifest that is being downloaded.</param>
        /// <param name="server">The content server to connect to.</param>
        /// <param name="depotKey">
        /// The depot decryption key for the depot that will be downloaded.
        /// This is used for decrypting filenames (if needed) in depot manifests, and processing depot chunks.
        /// </param>
        /// <param name="proxyServer">Optional content server marked as UseAsProxy which transforms the request.</param>
        /// <param name="cdnAuthToken">CDN auth token for CDN content server endpoints if necessary. Get one with <see cref="SteamContent.GetCDNAuthToken"/>.</param>
        /// <returns>A <see cref="DepotManifest"/> instance that contains information about the files present within a depot.</returns>
        /// <exception cref="System.ArgumentNullException"><see ref="server"/> was null.</exception>
        /// <exception cref="HttpRequestException">An network error occurred when performing the request.</exception>
        /// <exception cref="SteamKitWebRequestException">A network error occurred when performing the request.</exception>
        public async Task<DepotManifest> DownloadManifestAsync( uint depotId, ulong manifestId, ulong manifestRequestCode, Server? server, byte[]? depotKey = null, Server? proxyServer = null, string? cdnAuthToken = null )
        {
            const uint MANIFEST_VERSION = 5;
            string url;

            if ( manifestRequestCode > 0 )
            {
                url = $"depot/{depotId}/manifest/{manifestId}/{MANIFEST_VERSION}/{manifestRequestCode}";
            }
            else
            {
                url = $"depot/{depotId}/manifest/{manifestId}/{MANIFEST_VERSION}";
            }

            using var request = new HttpRequestMessage( HttpMethod.Get, BuildCommand( server, url, cdnAuthToken, proxyServer ) );

            using var cts = new CancellationTokenSource();
            cts.CancelAfter( RequestTimeout );

            DepotManifest depotManifest;

            try
            {
                using var response = await httpClient.SendAsync( request, HttpCompletionOption.ResponseHeadersRead, cts.Token ).ConfigureAwait( false );

                if ( !response.IsSuccessStatusCode )
                {
                    throw new SteamKitWebRequestException( $"Response status code does not indicate success: {response.StatusCode:D} ({response.ReasonPhrase}).", response );
                }

                cts.CancelAfter( ResponseBodyTimeout );

                var contentLength = -1;
                byte[]? buffer = null;

                if ( response.Content.Headers.ContentLength.HasValue )
                {
                    contentLength = ( int )response.Content.Headers.ContentLength;
                    buffer = ArrayPool<byte>.Shared.Rent( contentLength );
                }
                else
                {
                    DebugLog.WriteLine( nameof( CDN ), $"Manifest response does not have Content-Length, falling back to unbuffered read." );
                }

                try
                {
                    MemoryStream ms;

                    if ( buffer != null )
                    {
                        ms = new MemoryStream( buffer, 0, contentLength );

                        // Stream the http response into the rented buffer
                        await response.Content.CopyToAsync( ms, cts.Token );

                        if ( ms.Position != contentLength )
                        {
                            throw new InvalidDataException( $"Length mismatch after downloading depot manifest! (was {ms.Position}, but should be {contentLength})" );
                        }

                        ms.Position = 0;
                    }
                    else
                    {
                        var data = await response.Content.ReadAsByteArrayAsync();
                        ms = new MemoryStream( data );
                    }

                    // Decompress the zipped manifest data
                    using var zip = new ZipArchive( ms );
                    var entries = zip.Entries;

                    DebugLog.Assert( entries.Count == 1, nameof( CDN ), "Expected the zip to contain only one file" );

                    using var zipEntryStream = entries[ 0 ].Open();
                    depotManifest = DepotManifest.Deserialize( zipEntryStream );

                    ms.Dispose();
                }
                finally
                {
                    if ( buffer != null )
                    {
                        ArrayPool<byte>.Shared.Return( buffer );
                    }
                }
            }
            catch ( Exception ex )
            {
                DebugLog.WriteLine( nameof( CDN ), $"Failed to download manifest {request.RequestUri}: {ex.Message}" );
                throw;
            }

            if ( depotKey != null )
            {
                // if we have the depot key, decrypt the manifest filenames
                depotManifest.DecryptFilenames( depotKey );
            }

            return depotManifest;
        }

        /// <summary>
        /// Downloads the specified depot chunk, and optionally processes the chunk and verifies the checksum if the depot decryption key has been provided.
        /// </summary>
        /// <remarks>
        /// This function will also validate the length of the downloaded chunk with the value of <see cref="DepotManifest.ChunkData.CompressedLength"/>,
        /// if it has been assigned a value.
        /// </remarks>
        /// <param name="depotId">The id of the depot being accessed.</param>
        /// <param name="chunk">
        /// A <see cref="DepotManifest.ChunkData"/> instance that represents the chunk to download.
        /// This value should come from a manifest downloaded with <see cref="o:DownloadManifestAsync"/>.
        /// </param>
        /// <returns>A <see cref="DepotChunk"/> instance that contains the data for the given chunk.</returns>
        /// <param name="server">The content server to connect to.</param>
        /// <param name="depotKey">
        /// The depot decryption key for the depot that will be downloaded.
        /// This is used for decrypting filenames (if needed) in depot manifests, and processing depot chunks.
        /// </param>
        /// <param name="isLocal">
        /// If true, the data is downloaded from neighboring instance and we don't need to decrypt and decompress it.
        /// </param>
        /// <param name="proxyServer">Optional content server marked as UseAsProxy which transforms the request.</param>
        /// <param name="cdnAuthToken">CDN auth token for CDN content server endpoints if necessary. Get one with <see cref="SteamContent.GetCDNAuthToken"/>.</param>
        /// <exception cref="System.ArgumentNullException">chunk's <see cref="DepotManifest.ChunkData.ChunkID"/> was null.</exception>
        /// <exception cref="System.IO.InvalidDataException">Thrown if the downloaded data does not match the expected length.</exception>
        /// <exception cref="HttpRequestException">An network error occurred when performing the request.</exception>
        /// <exception cref="SteamKitWebRequestException">A network error occurred when performing the request.</exception>
        public async Task<DepotChunk> DownloadDepotChunkAsync( uint depotId, DepotManifest.ChunkData chunk, Server? server, byte[]? depotKey = null, Server? proxyServer = null, string? cdnAuthToken = null, bool isLocal = false )
        {
            ArgumentNullException.ThrowIfNull( chunk );

            if ( chunk.ChunkID == null )
            {
                throw new ArgumentException( "Chunk must have a ChunkID.", nameof( chunk ) );
            }

            var chunkID = Utils.EncodeHexString( chunk.ChunkID );

            var chunkData = await DoRawCommandAsync( server, $"depot/{depotId}/chunk/{chunkID}", proxyServer, cdnAuthToken ).ConfigureAwait( false );

            var depotChunk = new DepotChunk( chunk, chunkData );

            // In case we download locally - data is not compressed and we don't need to process it
            if ( isLocal )
            {
                try
                {
                    depotChunk.VerifyChecksum();
                }
                catch ( Exception )
                {
                    depotChunk.Dispose();
                    throw;
                }

                depotChunk.IsProcessed = true;
                return depotChunk;
            }

            // assert that lengths match only if the chunk has a length assigned.
            if ( chunk.CompressedLength > 0 && chunkData.Count != chunk.CompressedLength )
            {
                depotChunk.Dispose();
                throw new InvalidDataException( $"Length mismatch after downloading depot chunk! (was {chunkData.Count}, but should be {chunk.CompressedLength})" );
            }

            if ( depotKey != null )
            {
                try
                {
                    // if we have the depot key, we can process the chunk immediately
                    depotChunk.Process( depotKey );
                }
                catch ( Exception )
                {
                    depotChunk.Dispose();
                    throw;
                }
            }

            return depotChunk;
        }

        /// <summary>
        /// Returns ArraySegment allocated using ArrayPool, subsequently it must be disposed by the receiver.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="command"></param>
        /// <param name="proxyServer"></param>
        /// <param name="cdnAuthToken"></param>
        /// <returns></returns>
        async Task<ArraySegment<byte>> DoRawCommandAsync( Server? server, string command, Server? proxyServer, string? cdnAuthToken = null )
        {
            var url = BuildCommand( server, command, cdnAuthToken, proxyServer );

            using var cts = new CancellationTokenSource();
            cts.CancelAfter( RequestTimeout );

            try
            {
                using var response = await httpClient.GetAsync( url, HttpCompletionOption.ResponseHeadersRead, cts.Token ).ConfigureAwait( false );

                if ( !response.IsSuccessStatusCode )
                {
                    throw new SteamKitWebRequestException( $"Response status code does not indicate success: {response.StatusCode:D} ({response.ReasonPhrase}).", response );
                }

                cts.CancelAfter( ResponseBodyTimeout );

                // await response.Content.LoadIntoBufferAsync().ConfigureAwait( false );

                int bufferSize = ( int? )response.Content.Headers?.ContentLength ?? 2 * 1024 * 1024;
                byte[] buffer = ArrayPool<byte>.Shared.Rent( bufferSize );

                var stream = response.Content.ReadAsStream();
                int bytesRead = 0;
                int offset = 0;
                do
                {
                    bytesRead = await stream.ReadAsync( buffer.AsMemory()[offset..], cts.Token ).ConfigureAwait( false );
                    offset += bytesRead;
                }
                while ( bytesRead != 0 );

                return new ArraySegment<byte>( buffer, 0, offset );
            }
            catch ( Exception ex )
            {
                DebugLog.WriteLine( nameof( CDN ), "Failed to complete web request to {0}: {1}", url, ex.Message );
                throw;
            }
        }

        static Uri BuildCommand( Server? server, string command, string? query, Server? proxyServer )
        {
            if ( server == null )
                return new Uri( command, UriKind.Relative );

            var uriBuilder = new UriBuilder
            {
                Scheme = server.Protocol == Server.ConnectionProtocol.HTTP ? "http" : "https",
                Host = server.VHost,
                Port = server.Port,
                Path = command,
                Query = query ?? string.Empty,
            };

            if ( proxyServer != null && proxyServer.UseAsProxy && proxyServer.ProxyRequestPathTemplate != null )
            {
                var pathTemplate = proxyServer.ProxyRequestPathTemplate;
                pathTemplate = pathTemplate.Replace( "%host%", uriBuilder.Host, StringComparison.Ordinal );
                pathTemplate = pathTemplate.Replace( "%path%", $"/{uriBuilder.Path}", StringComparison.Ordinal );
                uriBuilder.Scheme = proxyServer.Protocol == Server.ConnectionProtocol.HTTP ? "http" : "https";
                uriBuilder.Host = proxyServer.VHost;
                uriBuilder.Port = proxyServer.Port;
                uriBuilder.Path = pathTemplate;
            }

            return uriBuilder.Uri;
        }
    }
}
