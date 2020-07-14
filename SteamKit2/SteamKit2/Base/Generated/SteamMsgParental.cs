// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_parental.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ParentalApp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public bool is_allowed
        {
            get => __pbn__is_allowed.GetValueOrDefault();
            set => __pbn__is_allowed = value;
        }
        public bool ShouldSerializeis_allowed() => __pbn__is_allowed != null;
        public void Resetis_allowed() => __pbn__is_allowed = null;
        private bool? __pbn__is_allowed;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ParentalSettings : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint applist_base_id
        {
            get => __pbn__applist_base_id.GetValueOrDefault();
            set => __pbn__applist_base_id = value;
        }
        public bool ShouldSerializeapplist_base_id() => __pbn__applist_base_id != null;
        public void Resetapplist_base_id() => __pbn__applist_base_id = null;
        private uint? __pbn__applist_base_id;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string applist_base_description
        {
            get => __pbn__applist_base_description ?? "";
            set => __pbn__applist_base_description = value;
        }
        public bool ShouldSerializeapplist_base_description() => __pbn__applist_base_description != null;
        public void Resetapplist_base_description() => __pbn__applist_base_description = null;
        private string __pbn__applist_base_description;

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<ParentalApp> applist_base { get; } = new global::System.Collections.Generic.List<ParentalApp>();

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<ParentalApp> applist_custom { get; } = new global::System.Collections.Generic.List<ParentalApp>();

        [global::ProtoBuf.ProtoMember(6)]
        public uint passwordhashtype
        {
            get => __pbn__passwordhashtype.GetValueOrDefault();
            set => __pbn__passwordhashtype = value;
        }
        public bool ShouldSerializepasswordhashtype() => __pbn__passwordhashtype != null;
        public void Resetpasswordhashtype() => __pbn__passwordhashtype = null;
        private uint? __pbn__passwordhashtype;

        [global::ProtoBuf.ProtoMember(7)]
        public byte[] salt
        {
            get => __pbn__salt;
            set => __pbn__salt = value;
        }
        public bool ShouldSerializesalt() => __pbn__salt != null;
        public void Resetsalt() => __pbn__salt = null;
        private byte[] __pbn__salt;

        [global::ProtoBuf.ProtoMember(8)]
        public byte[] passwordhash
        {
            get => __pbn__passwordhash;
            set => __pbn__passwordhash = value;
        }
        public bool ShouldSerializepasswordhash() => __pbn__passwordhash != null;
        public void Resetpasswordhash() => __pbn__passwordhash = null;
        private byte[] __pbn__passwordhash;

        [global::ProtoBuf.ProtoMember(9)]
        public bool is_enabled
        {
            get => __pbn__is_enabled.GetValueOrDefault();
            set => __pbn__is_enabled = value;
        }
        public bool ShouldSerializeis_enabled() => __pbn__is_enabled != null;
        public void Resetis_enabled() => __pbn__is_enabled = null;
        private bool? __pbn__is_enabled;

        [global::ProtoBuf.ProtoMember(10)]
        public uint enabled_features
        {
            get => __pbn__enabled_features.GetValueOrDefault();
            set => __pbn__enabled_features = value;
        }
        public bool ShouldSerializeenabled_features() => __pbn__enabled_features != null;
        public void Resetenabled_features() => __pbn__enabled_features = null;
        private uint? __pbn__enabled_features;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string recovery_email
        {
            get => __pbn__recovery_email ?? "";
            set => __pbn__recovery_email = value;
        }
        public bool ShouldSerializerecovery_email() => __pbn__recovery_email != null;
        public void Resetrecovery_email() => __pbn__recovery_email = null;
        private string __pbn__recovery_email;

        [global::ProtoBuf.ProtoMember(12)]
        public bool is_site_license_lock
        {
            get => __pbn__is_site_license_lock.GetValueOrDefault();
            set => __pbn__is_site_license_lock = value;
        }
        public bool ShouldSerializeis_site_license_lock() => __pbn__is_site_license_lock != null;
        public void Resetis_site_license_lock() => __pbn__is_site_license_lock = null;
        private bool? __pbn__is_site_license_lock;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_EnableParentalSettings_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string password
        {
            get => __pbn__password ?? "";
            set => __pbn__password = value;
        }
        public bool ShouldSerializepassword() => __pbn__password != null;
        public void Resetpassword() => __pbn__password = null;
        private string __pbn__password;

        [global::ProtoBuf.ProtoMember(2)]
        public ParentalSettings settings { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sessionid
        {
            get => __pbn__sessionid ?? "";
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private string __pbn__sessionid;

        [global::ProtoBuf.ProtoMember(4)]
        public uint enablecode
        {
            get => __pbn__enablecode.GetValueOrDefault();
            set => __pbn__enablecode = value;
        }
        public bool ShouldSerializeenablecode() => __pbn__enablecode != null;
        public void Resetenablecode() => __pbn__enablecode = null;
        private uint? __pbn__enablecode;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_EnableParentalSettings_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_DisableParentalSettings_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string password
        {
            get => __pbn__password ?? "";
            set => __pbn__password = value;
        }
        public bool ShouldSerializepassword() => __pbn__password != null;
        public void Resetpassword() => __pbn__password = null;
        private string __pbn__password;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_DisableParentalSettings_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_GetParentalSettings_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_GetParentalSettings_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ParentalSettings settings { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_GetSignedParentalSettings_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint priority
        {
            get => __pbn__priority.GetValueOrDefault();
            set => __pbn__priority = value;
        }
        public bool ShouldSerializepriority() => __pbn__priority != null;
        public void Resetpriority() => __pbn__priority = null;
        private uint? __pbn__priority;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_GetSignedParentalSettings_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public byte[] serialized_settings
        {
            get => __pbn__serialized_settings;
            set => __pbn__serialized_settings = value;
        }
        public bool ShouldSerializeserialized_settings() => __pbn__serialized_settings != null;
        public void Resetserialized_settings() => __pbn__serialized_settings = null;
        private byte[] __pbn__serialized_settings;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] signature
        {
            get => __pbn__signature;
            set => __pbn__signature = value;
        }
        public bool ShouldSerializesignature() => __pbn__signature != null;
        public void Resetsignature() => __pbn__signature = null;
        private byte[] __pbn__signature;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_SetParentalSettings_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string password
        {
            get => __pbn__password ?? "";
            set => __pbn__password = value;
        }
        public bool ShouldSerializepassword() => __pbn__password != null;
        public void Resetpassword() => __pbn__password = null;
        private string __pbn__password;

        [global::ProtoBuf.ProtoMember(2)]
        public ParentalSettings settings { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string new_password
        {
            get => __pbn__new_password ?? "";
            set => __pbn__new_password = value;
        }
        public bool ShouldSerializenew_password() => __pbn__new_password != null;
        public void Resetnew_password() => __pbn__new_password = null;
        private string __pbn__new_password;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sessionid
        {
            get => __pbn__sessionid ?? "";
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private string __pbn__sessionid;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_SetParentalSettings_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ValidateToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string unlock_token
        {
            get => __pbn__unlock_token ?? "";
            set => __pbn__unlock_token = value;
        }
        public bool ShouldSerializeunlock_token() => __pbn__unlock_token != null;
        public void Resetunlock_token() => __pbn__unlock_token = null;
        private string __pbn__unlock_token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ValidateToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ValidatePassword_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string password
        {
            get => __pbn__password ?? "";
            set => __pbn__password = value;
        }
        public bool ShouldSerializepassword() => __pbn__password != null;
        public void Resetpassword() => __pbn__password = null;
        private string __pbn__password;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string session
        {
            get => __pbn__session ?? "";
            set => __pbn__session = value;
        }
        public bool ShouldSerializesession() => __pbn__session != null;
        public void Resetsession() => __pbn__session = null;
        private string __pbn__session;

        [global::ProtoBuf.ProtoMember(3)]
        public bool send_unlock_on_success
        {
            get => __pbn__send_unlock_on_success.GetValueOrDefault();
            set => __pbn__send_unlock_on_success = value;
        }
        public bool ShouldSerializesend_unlock_on_success() => __pbn__send_unlock_on_success != null;
        public void Resetsend_unlock_on_success() => __pbn__send_unlock_on_success = null;
        private bool? __pbn__send_unlock_on_success;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ValidatePassword_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string token
        {
            get => __pbn__token ?? "";
            set => __pbn__token = value;
        }
        public bool ShouldSerializetoken() => __pbn__token != null;
        public void Resettoken() => __pbn__token = null;
        private string __pbn__token;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_LockClient_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string session
        {
            get => __pbn__session ?? "";
            set => __pbn__session = value;
        }
        public bool ShouldSerializesession() => __pbn__session != null;
        public void Resetsession() => __pbn__session = null;
        private string __pbn__session;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_LockClient_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_RequestRecoveryCode_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_RequestRecoveryCode_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_DisableWithRecoveryCode_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint recovery_code
        {
            get => __pbn__recovery_code.GetValueOrDefault();
            set => __pbn__recovery_code = value;
        }
        public bool ShouldSerializerecovery_code() => __pbn__recovery_code != null;
        public void Resetrecovery_code() => __pbn__recovery_code = null;
        private uint? __pbn__recovery_code;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get => __pbn__steamid.GetValueOrDefault();
            set => __pbn__steamid = value;
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_DisableWithRecoveryCode_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ParentalSettingsChange_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public byte[] serialized_settings
        {
            get => __pbn__serialized_settings;
            set => __pbn__serialized_settings = value;
        }
        public bool ShouldSerializeserialized_settings() => __pbn__serialized_settings != null;
        public void Resetserialized_settings() => __pbn__serialized_settings = null;
        private byte[] __pbn__serialized_settings;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] signature
        {
            get => __pbn__signature;
            set => __pbn__signature = value;
        }
        public bool ShouldSerializesignature() => __pbn__signature != null;
        public void Resetsignature() => __pbn__signature = null;
        private byte[] __pbn__signature;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string password
        {
            get => __pbn__password ?? "";
            set => __pbn__password = value;
        }
        public bool ShouldSerializepassword() => __pbn__password != null;
        public void Resetpassword() => __pbn__password = null;
        private string __pbn__password;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sessionid
        {
            get => __pbn__sessionid ?? "";
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private string __pbn__sessionid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ParentalUnlock_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string password
        {
            get => __pbn__password ?? "";
            set => __pbn__password = value;
        }
        public bool ShouldSerializepassword() => __pbn__password != null;
        public void Resetpassword() => __pbn__password = null;
        private string __pbn__password;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sessionid
        {
            get => __pbn__sessionid ?? "";
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private string __pbn__sessionid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CParental_ParentalLock_Notification : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sessionid
        {
            get => __pbn__sessionid ?? "";
            set => __pbn__sessionid = value;
        }
        public bool ShouldSerializesessionid() => __pbn__sessionid != null;
        public void Resetsessionid() => __pbn__sessionid = null;
        private string __pbn__sessionid;

    }

    public interface IParental
    {
        CParental_EnableParentalSettings_Response EnableParentalSettings(CParental_EnableParentalSettings_Request request);
        CParental_DisableParentalSettings_Response DisableParentalSettings(CParental_DisableParentalSettings_Request request);
        CParental_GetParentalSettings_Response GetParentalSettings(CParental_GetParentalSettings_Request request);
        CParental_GetSignedParentalSettings_Response GetSignedParentalSettings(CParental_GetSignedParentalSettings_Request request);
        CParental_SetParentalSettings_Response SetParentalSettings(CParental_SetParentalSettings_Request request);
        CParental_ValidateToken_Response ValidateToken(CParental_ValidateToken_Request request);
        CParental_ValidatePassword_Response ValidatePassword(CParental_ValidatePassword_Request request);
        CParental_LockClient_Response LockClient(CParental_LockClient_Request request);
        CParental_RequestRecoveryCode_Response RequestRecoveryCode(CParental_RequestRecoveryCode_Request request);
        CParental_DisableWithRecoveryCode_Response DisableWithRecoveryCode(CParental_DisableWithRecoveryCode_Request request);
    }

    public interface IParentalClient
    {
        NoResponse NotifySettingsChange(CParental_ParentalSettingsChange_Notification request);
        NoResponse NotifyUnlock(CParental_ParentalUnlock_Notification request);
        NoResponse NotifyLock(CParental_ParentalLock_Notification request);
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion