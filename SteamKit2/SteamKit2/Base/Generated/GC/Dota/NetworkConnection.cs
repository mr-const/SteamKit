// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: network_connection.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.Dota.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public enum ENetworkDisconnectionReason
    {
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_INVALID")]
        NetworkDisconnectInvalid = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SHUTDOWN")]
        NetworkDisconnectShutdown = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_DISCONNECT_BY_USER")]
        NetworkDisconnectDisconnectByUser = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_DISCONNECT_BY_SERVER")]
        NetworkDisconnectDisconnectByServer = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOST")]
        NetworkDisconnectLost = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_OVERFLOW")]
        NetworkDisconnectOverflow = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_BANNED")]
        NetworkDisconnectSteamBanned = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_INUSE")]
        NetworkDisconnectSteamInuse = 7,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_TICKET")]
        NetworkDisconnectSteamTicket = 8,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_LOGON")]
        NetworkDisconnectSteamLogon = 9,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_AUTHCANCELLED")]
        NetworkDisconnectSteamAuthcancelled = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED")]
        NetworkDisconnectSteamAuthalreadyused = 11,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_AUTHINVALID")]
        NetworkDisconnectSteamAuthinvalid = 12,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_VACBANSTATE")]
        NetworkDisconnectSteamVacbanstate = 13,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE")]
        NetworkDisconnectSteamLoggedInElsewhere = 14,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT")]
        NetworkDisconnectSteamVacCheckTimedout = 15,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_DROPPED")]
        NetworkDisconnectSteamDropped = 16,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_OWNERSHIP")]
        NetworkDisconnectSteamOwnership = 17,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SERVERINFO_OVERFLOW")]
        NetworkDisconnectServerinfoOverflow = 18,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_TICKMSG_OVERFLOW")]
        NetworkDisconnectTickmsgOverflow = 19,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW")]
        NetworkDisconnectStringtablemsgOverflow = 20,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW")]
        NetworkDisconnectDeltaentmsgOverflow = 21,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW")]
        NetworkDisconnectTempentmsgOverflow = 22,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW")]
        NetworkDisconnectSoundsmsgOverflow = 23,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SNAPSHOTOVERFLOW")]
        NetworkDisconnectSnapshotoverflow = 24,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SNAPSHOTERROR")]
        NetworkDisconnectSnapshoterror = 25,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_RELIABLEOVERFLOW")]
        NetworkDisconnectReliableoverflow = 26,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_BADDELTATICK")]
        NetworkDisconnectBaddeltatick = 27,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_NOMORESPLITS")]
        NetworkDisconnectNomoresplits = 28,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_TIMEDOUT")]
        NetworkDisconnectTimedout = 29,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_DISCONNECTED")]
        NetworkDisconnectDisconnected = 30,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LEAVINGSPLIT")]
        NetworkDisconnectLeavingsplit = 31,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_DIFFERENTCLASSTABLES")]
        NetworkDisconnectDifferentclasstables = 32,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_BADRELAYPASSWORD")]
        NetworkDisconnectBadrelaypassword = 33,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_BADSPECTATORPASSWORD")]
        NetworkDisconnectBadspectatorpassword = 34,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_HLTVRESTRICTED")]
        NetworkDisconnectHltvrestricted = 35,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_NOSPECTATORS")]
        NetworkDisconnectNospectators = 36,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_HLTVUNAVAILABLE")]
        NetworkDisconnectHltvunavailable = 37,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_HLTVSTOP")]
        NetworkDisconnectHltvstop = 38,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_KICKED")]
        NetworkDisconnectKicked = 39,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_BANADDED")]
        NetworkDisconnectBanadded = 40,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_KICKBANADDED")]
        NetworkDisconnectKickbanadded = 41,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_HLTVDIRECT")]
        NetworkDisconnectHltvdirect = 42,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA")]
        NetworkDisconnectPureserverClientextra = 43,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_PURESERVER_MISMATCH")]
        NetworkDisconnectPureserverMismatch = 44,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_USERCMD")]
        NetworkDisconnectUsercmd = 45,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECTED_BY_GAME")]
        NetworkDisconnectRejectedByGame = 46,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR")]
        NetworkDisconnectMessageParseError = 47,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR")]
        NetworkDisconnectInvalidMessageError = 48,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_BAD_SERVER_PASSWORD")]
        NetworkDisconnectBadServerPassword = 49,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION")]
        NetworkDisconnectDirectConnectReservation = 50,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CONNECTION_FAILURE")]
        NetworkDisconnectConnectionFailure = 51,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS")]
        NetworkDisconnectNoPeerGroupHandlers = 52,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_RECONNECTION")]
        NetworkDisconnectReconnection = 53,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOOPSHUTDOWN")]
        NetworkDisconnectLoopshutdown = 54,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOOPDEACTIVATE")]
        NetworkDisconnectLoopdeactivate = 55,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_HOST_ENDGAME")]
        NetworkDisconnectHostEndgame = 56,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE")]
        NetworkDisconnectLoopLevelloadActivate = 57,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CREATE_SERVER_FAILED")]
        NetworkDisconnectCreateServerFailed = 58,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_EXITING")]
        NetworkDisconnectExiting = 59,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE")]
        NetworkDisconnectRequestHoststateIdle = 60,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY")]
        NetworkDisconnectRequestHoststateHltvrelay = 61,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL")]
        NetworkDisconnectClientConsistencyFail = 62,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP")]
        NetworkDisconnectClientUnableToCrcMap = 63,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CLIENT_NO_MAP")]
        NetworkDisconnectClientNoMap = 64,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP")]
        NetworkDisconnectClientDifferentMap = 65,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM")]
        NetworkDisconnectServerRequiresSteam = 66,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_DENY_MISC")]
        NetworkDisconnectSteamDenyMisc = 67,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT")]
        NetworkDisconnectSteamDenyBadAntiCheat = 68,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SERVER_SHUTDOWN")]
        NetworkDisconnectServerShutdown = 69,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SPLITPACKET_SEND_OVERFLOW")]
        NetworkDisconnectSplitpacketSendOverflow = 70,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE")]
        NetworkDisconnectReplayIncompatible = 71,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_CONNECT_REQUEST_TIMEDOUT")]
        NetworkDisconnectConnectRequestTimedout = 72,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_SERVER_INCOMPATIBLE")]
        NetworkDisconnectServerIncompatible = 73,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOCALPROBLEM_MANYRELAYS")]
        NetworkDisconnectLocalproblemManyrelays = 74,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOCALPROBLEM_HOSTEDSERVERPRIMARYRELAY")]
        NetworkDisconnectLocalproblemHostedserverprimaryrelay = 75,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOCALPROBLEM_NETWORKCONFIG")]
        NetworkDisconnectLocalproblemNetworkconfig = 76,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_LOCALPROBLEM_OTHER")]
        NetworkDisconnectLocalproblemOther = 77,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REMOTE_TIMEOUT")]
        NetworkDisconnectRemoteTimeout = 79,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REMOTE_TIMEOUT_CONNECTING")]
        NetworkDisconnectRemoteTimeoutConnecting = 80,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REMOTE_OTHER")]
        NetworkDisconnectRemoteOther = 81,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REMOTE_BADCRYPT")]
        NetworkDisconnectRemoteBadcrypt = 82,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REMOTE_CERTNOTTRUSTED")]
        NetworkDisconnectRemoteCertnottrusted = 83,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_UNUSUAL")]
        NetworkDisconnectUnusual = 84,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_INTERNAL_ERROR")]
        NetworkDisconnectInternalError = 85,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_BADCHALLENGE")]
        NetworkDisconnectRejectBadchallenge = 128,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_NOLOBBY")]
        NetworkDisconnectRejectNolobby = 129,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_BACKGROUND_MAP")]
        NetworkDisconnectRejectBackgroundMap = 130,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_SINGLE_PLAYER")]
        NetworkDisconnectRejectSinglePlayer = 131,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_HIDDEN_GAME")]
        NetworkDisconnectRejectHiddenGame = 132,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_LANRESTRICT")]
        NetworkDisconnectRejectLanrestrict = 133,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_BADPASSWORD")]
        NetworkDisconnectRejectBadpassword = 134,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_SERVERFULL")]
        NetworkDisconnectRejectServerfull = 135,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_INVALIDRESERVATION")]
        NetworkDisconnectRejectInvalidreservation = 136,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_FAILEDCHANNEL")]
        NetworkDisconnectRejectFailedchannel = 137,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_CONNECT_FROM_LOBBY")]
        NetworkDisconnectRejectConnectFromLobby = 138,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_RESERVED_FOR_LOBBY")]
        NetworkDisconnectRejectReservedForLobby = 139,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_INVALIDKEYLENGTH")]
        NetworkDisconnectRejectInvalidkeylength = 140,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_OLDPROTOCOL")]
        NetworkDisconnectRejectOldprotocol = 141,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_NEWPROTOCOL")]
        NetworkDisconnectRejectNewprotocol = 142,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_INVALIDCONNECTION")]
        NetworkDisconnectRejectInvalidconnection = 143,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_INVALIDCERTLEN")]
        NetworkDisconnectRejectInvalidcertlen = 144,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_INVALIDSTEAMCERTLEN")]
        NetworkDisconnectRejectInvalidsteamcertlen = 145,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_STEAM")]
        NetworkDisconnectRejectSteam = 146,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_SERVERAUTHDISABLED")]
        NetworkDisconnectRejectServerauthdisabled = 147,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_SERVERCDKEYAUTHINVALID")]
        NetworkDisconnectRejectServercdkeyauthinvalid = 148,
        [global::ProtoBuf.ProtoEnum(Name = @"NETWORK_DISCONNECT_REJECT_BANNED")]
        NetworkDisconnectRejectBanned = 149,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
