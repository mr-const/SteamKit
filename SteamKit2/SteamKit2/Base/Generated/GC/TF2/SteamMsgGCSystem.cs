// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: gcsystemmsgs.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.TF2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GamePersonalDataCategoryInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string type
        {
            get { return __pbn__type ?? ""; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private string __pbn__type;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string localization_token
        {
            get { return __pbn__localization_token ?? ""; }
            set { __pbn__localization_token = value; }
        }
        public bool ShouldSerializelocalization_token() => __pbn__localization_token != null;
        public void Resetlocalization_token() => __pbn__localization_token = null;
        private string __pbn__localization_token;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string template_file
        {
            get { return __pbn__template_file ?? ""; }
            set { __pbn__template_file = value; }
        }
        public bool ShouldSerializetemplate_file() => __pbn__template_file != null;
        public void Resettemplate_file() => __pbn__template_file = null;
        private string __pbn__template_file;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetGamePersonalDataCategories_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetGamePersonalDataCategories_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<CCommunity_GamePersonalDataCategoryInfo> categories { get; } = new global::System.Collections.Generic.List<CCommunity_GamePersonalDataCategoryInfo>();

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string app_assets_basename
        {
            get { return __pbn__app_assets_basename ?? ""; }
            set { __pbn__app_assets_basename = value; }
        }
        public bool ShouldSerializeapp_assets_basename() => __pbn__app_assets_basename != null;
        public void Resetapp_assets_basename() => __pbn__app_assets_basename = null;
        private string __pbn__app_assets_basename;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetGamePersonalDataEntries_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string type
        {
            get { return __pbn__type ?? ""; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private string __pbn__type;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string continue_token
        {
            get { return __pbn__continue_token ?? ""; }
            set { __pbn__continue_token = value; }
        }
        public bool ShouldSerializecontinue_token() => __pbn__continue_token != null;
        public void Resetcontinue_token() => __pbn__continue_token = null;
        private string __pbn__continue_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_GetGamePersonalDataEntries_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint gceresult
        {
            get { return __pbn__gceresult.GetValueOrDefault(); }
            set { __pbn__gceresult = value; }
        }
        public bool ShouldSerializegceresult() => __pbn__gceresult != null;
        public void Resetgceresult() => __pbn__gceresult = null;
        private uint? __pbn__gceresult;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<string> entries { get; } = new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string continue_token
        {
            get { return __pbn__continue_token ?? ""; }
            set { __pbn__continue_token = value; }
        }
        public bool ShouldSerializecontinue_token() => __pbn__continue_token != null;
        public void Resetcontinue_token() => __pbn__continue_token = null;
        private string __pbn__continue_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_TerminateGamePersonalDataEntries_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCommunity_TerminateGamePersonalDataEntries_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint gceresult
        {
            get { return __pbn__gceresult.GetValueOrDefault(); }
            set { __pbn__gceresult = value; }
        }
        public bool ShouldSerializegceresult() => __pbn__gceresult != null;
        public void Resetgceresult() => __pbn__gceresult = null;
        private uint? __pbn__gceresult;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGCSystemMsg
    {
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgInvalid")]
        kEGCMsgInvalid = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMulti")]
        kEGCMsgMulti = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGenericReply")]
        kEGCMsgGenericReply = 10,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSystemBase")]
        kEGCMsgSystemBase = 50,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAchievementAwarded")]
        kEGCMsgAchievementAwarded = 51,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgConCommand")]
        kEGCMsgConCommand = 52,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgStartPlaying")]
        kEGCMsgStartPlaying = 53,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgStopPlaying")]
        kEGCMsgStopPlaying = 54,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgStartGameserver")]
        kEGCMsgStartGameserver = 55,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgStopGameserver")]
        kEGCMsgStopGameserver = 56,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgWGRequest")]
        kEGCMsgWGRequest = 57,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgWGResponse")]
        kEGCMsgWGResponse = 58,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetUserGameStatsSchema")]
        kEGCMsgGetUserGameStatsSchema = 59,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetUserGameStatsSchemaResponse")]
        kEGCMsgGetUserGameStatsSchemaResponse = 60,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetUserStatsDEPRECATED")]
        kEGCMsgGetUserStatsDEPRECATED = 61,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetUserStatsResponse")]
        kEGCMsgGetUserStatsResponse = 62,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAppInfoUpdated")]
        kEGCMsgAppInfoUpdated = 63,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgValidateSession")]
        kEGCMsgValidateSession = 64,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgValidateSessionResponse")]
        kEGCMsgValidateSessionResponse = 65,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgLookupAccountFromInput")]
        kEGCMsgLookupAccountFromInput = 66,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSendHTTPRequest")]
        kEGCMsgSendHTTPRequest = 67,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSendHTTPRequestResponse")]
        kEGCMsgSendHTTPRequestResponse = 68,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgPreTestSetup")]
        kEGCMsgPreTestSetup = 69,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgRecordSupportAction")]
        kEGCMsgRecordSupportAction = 70,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetAccountDetails_DEPRECATED")]
        kEGCMsgGetAccountDetailsDEPRECATED = 71,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgReceiveInterAppMessage")]
        kEGCMsgReceiveInterAppMessage = 73,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgFindAccounts")]
        kEGCMsgFindAccounts = 74,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgPostAlert")]
        kEGCMsgPostAlert = 75,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetLicenses")]
        kEGCMsgGetLicenses = 76,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetUserStats")]
        kEGCMsgGetUserStats = 77,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetCommands")]
        kEGCMsgGetCommands = 78,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetCommandsResponse")]
        kEGCMsgGetCommandsResponse = 79,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAddFreeLicense")]
        kEGCMsgAddFreeLicense = 80,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAddFreeLicenseResponse")]
        kEGCMsgAddFreeLicenseResponse = 81,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetIPLocation")]
        kEGCMsgGetIPLocation = 82,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetIPLocationResponse")]
        kEGCMsgGetIPLocationResponse = 83,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSystemStatsSchema")]
        kEGCMsgSystemStatsSchema = 84,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetSystemStats")]
        kEGCMsgGetSystemStats = 85,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetSystemStatsResponse")]
        kEGCMsgGetSystemStatsResponse = 86,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSendEmail")]
        kEGCMsgSendEmail = 87,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSendEmailResponse")]
        kEGCMsgSendEmailResponse = 88,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetEmailTemplate")]
        kEGCMsgGetEmailTemplate = 89,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetEmailTemplateResponse")]
        kEGCMsgGetEmailTemplateResponse = 90,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGrantGuestPass")]
        kEGCMsgGrantGuestPass = 91,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGrantGuestPassResponse")]
        kEGCMsgGrantGuestPassResponse = 92,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetAccountDetails")]
        kEGCMsgGetAccountDetails = 93,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetAccountDetailsResponse")]
        kEGCMsgGetAccountDetailsResponse = 94,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetPersonaNames")]
        kEGCMsgGetPersonaNames = 95,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetPersonaNamesResponse")]
        kEGCMsgGetPersonaNamesResponse = 96,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMultiplexMsg")]
        kEGCMsgMultiplexMsg = 97,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgWebAPIRegisterInterfaces")]
        kEGCMsgWebAPIRegisterInterfaces = 101,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgWebAPIJobRequest")]
        kEGCMsgWebAPIJobRequest = 102,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgWebAPIJobRequestHttpResponse")]
        kEGCMsgWebAPIJobRequestHttpResponse = 104,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgWebAPIJobRequestForwardResponse")]
        kEGCMsgWebAPIJobRequestForwardResponse = 105,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMemCachedGet")]
        kEGCMsgMemCachedGet = 200,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMemCachedGetResponse")]
        kEGCMsgMemCachedGetResponse = 201,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMemCachedSet")]
        kEGCMsgMemCachedSet = 202,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMemCachedDelete")]
        kEGCMsgMemCachedDelete = 203,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMemCachedStats")]
        kEGCMsgMemCachedStats = 204,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMemCachedStatsResponse")]
        kEGCMsgMemCachedStatsResponse = 205,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSQLStats")]
        kEGCMsgSQLStats = 210,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSQLStatsResponse")]
        kEGCMsgSQLStatsResponse = 211,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMasterSetDirectory")]
        kEGCMsgMasterSetDirectory = 220,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMasterSetDirectoryResponse")]
        kEGCMsgMasterSetDirectoryResponse = 221,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMasterSetWebAPIRouting")]
        kEGCMsgMasterSetWebAPIRouting = 222,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMasterSetWebAPIRoutingResponse")]
        kEGCMsgMasterSetWebAPIRoutingResponse = 223,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMasterSetClientMsgRouting")]
        kEGCMsgMasterSetClientMsgRouting = 224,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgMasterSetClientMsgRoutingResponse")]
        kEGCMsgMasterSetClientMsgRoutingResponse = 225,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSetOptions")]
        kEGCMsgSetOptions = 226,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSetOptionsResponse")]
        kEGCMsgSetOptionsResponse = 227,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgSystemBase2")]
        kEGCMsgSystemBase2 = 500,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetPurchaseTrustStatus")]
        kEGCMsgGetPurchaseTrustStatus = 501,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetPurchaseTrustStatusResponse")]
        kEGCMsgGetPurchaseTrustStatusResponse = 502,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgUpdateSession")]
        kEGCMsgUpdateSession = 503,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGCAccountVacStatusChange")]
        kEGCMsgGCAccountVacStatusChange = 504,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgCheckFriendship")]
        kEGCMsgCheckFriendship = 505,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgCheckFriendshipResponse")]
        kEGCMsgCheckFriendshipResponse = 506,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetPartnerAccountLink")]
        kEGCMsgGetPartnerAccountLink = 507,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetPartnerAccountLinkResponse")]
        kEGCMsgGetPartnerAccountLinkResponse = 508,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgVSReportedSuspiciousActivity")]
        kEGCMsgVSReportedSuspiciousActivity = 509,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAccountTradeBanStatusChange")]
        kEGCMsgAccountTradeBanStatusChange = 510,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAccountLockStatusChange")]
        kEGCMsgAccountLockStatusChange = 511,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgDPPartnerMicroTxns")]
        kEGCMsgDPPartnerMicroTxns = 512,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgDPPartnerMicroTxnsResponse")]
        kEGCMsgDPPartnerMicroTxnsResponse = 513,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetIPASN")]
        kEGCMsgGetIPASN = 514,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetIPASNResponse")]
        kEGCMsgGetIPASNResponse = 515,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetAppFriendsList")]
        kEGCMsgGetAppFriendsList = 516,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetAppFriendsListResponse")]
        kEGCMsgGetAppFriendsListResponse = 517,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgVacVerificationChange")]
        kEGCMsgVacVerificationChange = 518,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAccountPhoneNumberChange")]
        kEGCMsgAccountPhoneNumberChange = 519,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgAccountTwoFactorChange")]
        kEGCMsgAccountTwoFactorChange = 520,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgCheckClanMembership")]
        kEGCMsgCheckClanMembership = 521,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgCheckClanMembershipResponse")]
        kEGCMsgCheckClanMembershipResponse = 522,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgInviteUserToLobby")]
        kEGCMsgInviteUserToLobby = 523,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetGamePersonalDataCategoriesRequest")]
        kEGCMsgGetGamePersonalDataCategoriesRequest = 524,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetGamePersonalDataCategoriesResponse")]
        kEGCMsgGetGamePersonalDataCategoriesResponse = 525,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetGamePersonalDataEntriesRequest")]
        kEGCMsgGetGamePersonalDataEntriesRequest = 526,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgGetGamePersonalDataEntriesResponse")]
        kEGCMsgGetGamePersonalDataEntriesResponse = 527,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgTerminateGamePersonalDataEntriesRequest")]
        kEGCMsgTerminateGamePersonalDataEntriesRequest = 528,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCMsgTerminateGamePersonalDataEntriesResponse")]
        kEGCMsgTerminateGamePersonalDataEntriesResponse = 529,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ESOMsg
    {
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_Create")]
        kESOMsgCreate = 21,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_Update")]
        kESOMsgUpdate = 22,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_Destroy")]
        kESOMsgDestroy = 23,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_CacheSubscribed")]
        kESOMsgCacheSubscribed = 24,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_CacheUnsubscribed")]
        kESOMsgCacheUnsubscribed = 25,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_UpdateMultiple")]
        kESOMsgUpdateMultiple = 26,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_CacheSubscriptionCheck")]
        kESOMsgCacheSubscriptionCheck = 27,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_CacheSubscriptionRefresh")]
        kESOMsgCacheSubscriptionRefresh = 28,
        [global::ProtoBuf.ProtoEnum(Name = @"k_ESOMsg_CacheSubscribedUpToDate")]
        kESOMsgCacheSubscribedUpToDate = 29,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGCBaseClientMsg
    {
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCPingRequest")]
        kEMsgGCPingRequest = 3001,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCPingResponse")]
        kEMsgGCPingResponse = 3002,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCClientWelcome")]
        kEMsgGCClientWelcome = 4004,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCServerWelcome")]
        kEMsgGCServerWelcome = 4005,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCClientHello")]
        kEMsgGCClientHello = 4006,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCServerHello")]
        kEMsgGCServerHello = 4007,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCClientGoodbye")]
        kEMsgGCClientGoodbye = 4008,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCServerGoodbye")]
        kEMsgGCServerGoodbye = 4009,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGCToGCMsg
    {
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCToGCMsgMasterAck")]
        kEGCToGCMsgMasterAck = 150,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCToGCMsgMasterAckResponse")]
        kEGCToGCMsgMasterAckResponse = 151,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCToGCMsgRouted")]
        kEGCToGCMsgRouted = 152,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCToGCMsgRoutedReply")]
        kEGCToGCMsgRoutedReply = 153,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCUpdateSubGCSessionInfo")]
        kEMsgGCUpdateSubGCSessionInfo = 154,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCRequestSubGCSessionInfo")]
        kEMsgGCRequestSubGCSessionInfo = 155,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCRequestSubGCSessionInfoResponse")]
        kEMsgGCRequestSubGCSessionInfoResponse = 156,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EGCToGCMsgMasterStartupComplete")]
        kEGCToGCMsgMasterStartupComplete = 157,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCToGCSOCacheSubscribe")]
        kEMsgGCToGCSOCacheSubscribe = 158,
        [global::ProtoBuf.ProtoEnum(Name = @"k_EMsgGCToGCSOCacheUnsubscribe")]
        kEMsgGCToGCSOCacheUnsubscribe = 159,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
