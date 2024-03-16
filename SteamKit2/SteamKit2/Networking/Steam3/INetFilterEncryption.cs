/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */



using System;

namespace SteamKit2
{
    interface INetFilterEncryption
    {
        ArraySegment<byte> ProcessIncoming( byte[] data );
        byte[] ProcessOutgoing( byte[] data );
    }
}
