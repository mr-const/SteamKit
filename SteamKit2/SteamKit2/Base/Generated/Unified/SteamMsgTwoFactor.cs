//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_twofactor.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_Status_Request")]
  public partial class CTwoFactor_Status_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_Status_Request() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_Status_Response")]
  public partial class CTwoFactor_Status_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_Status_Response() {}
    

    private uint _state = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }

    private uint _inactivation_reason = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"inactivation_reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint inactivation_reason
    {
      get { return _inactivation_reason; }
      set { _inactivation_reason = value; }
    }

    private uint _authenticator_type = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"authenticator_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint authenticator_type
    {
      get { return _authenticator_type; }
      set { _authenticator_type = value; }
    }

    private bool _authenticator_allowed = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"authenticator_allowed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool authenticator_allowed
    {
      get { return _authenticator_allowed; }
      set { _authenticator_allowed = value; }
    }

    private uint _steamguard_scheme = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"steamguard_scheme", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint steamguard_scheme
    {
      get { return _steamguard_scheme; }
      set { _steamguard_scheme = value; }
    }

    private string _token_gid = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"token_gid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string token_gid
    {
      get { return _token_gid; }
      set { _token_gid = value; }
    }

    private bool _email_validated = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"email_validated", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool email_validated
    {
      get { return _email_validated; }
      set { _email_validated = value; }
    }

    private string _device_identifier = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"device_identifier", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string device_identifier
    {
      get { return _device_identifier; }
      set { _device_identifier = value; }
    }

    private uint _time_created = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"time_created", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time_created
    {
      get { return _time_created; }
      set { _time_created = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_AddAuthenticator_Request")]
  public partial class CTwoFactor_AddAuthenticator_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_AddAuthenticator_Request() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private ulong _authenticator_time = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"authenticator_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong authenticator_time
    {
      get { return _authenticator_time; }
      set { _authenticator_time = value; }
    }

    private ulong _serial_number = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }

    private uint _authenticator_type = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"authenticator_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint authenticator_type
    {
      get { return _authenticator_type; }
      set { _authenticator_type = value; }
    }

    private string _device_identifier = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"device_identifier", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string device_identifier
    {
      get { return _device_identifier; }
      set { _device_identifier = value; }
    }

    private string _sms_phone_id = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"sms_phone_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sms_phone_id
    {
      get { return _sms_phone_id; }
      set { _sms_phone_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_AddAuthenticator_Response")]
  public partial class CTwoFactor_AddAuthenticator_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_AddAuthenticator_Response() {}
    

    private byte[] _shared_secret = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"shared_secret", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] shared_secret
    {
      get { return _shared_secret; }
      set { _shared_secret = value; }
    }

    private ulong _serial_number = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }

    private string _revocation_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"revocation_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string revocation_code
    {
      get { return _revocation_code; }
      set { _revocation_code = value; }
    }

    private string _uri = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"uri", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string uri
    {
      get { return _uri; }
      set { _uri = value; }
    }

    private ulong _server_time = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"server_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong server_time
    {
      get { return _server_time; }
      set { _server_time = value; }
    }

    private string _account_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"account_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string account_name
    {
      get { return _account_name; }
      set { _account_name = value; }
    }

    private string _token_gid = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"token_gid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string token_gid
    {
      get { return _token_gid; }
      set { _token_gid = value; }
    }

    private byte[] _identity_secret = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"identity_secret", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] identity_secret
    {
      get { return _identity_secret; }
      set { _identity_secret = value; }
    }

    private byte[] _secret_1 = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"secret_1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] secret_1
    {
      get { return _secret_1; }
      set { _secret_1 = value; }
    }

    private int _status = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_SendEmail_Request")]
  public partial class CTwoFactor_SendEmail_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_SendEmail_Request() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private uint _email_type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"email_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint email_type
    {
      get { return _email_type; }
      set { _email_type = value; }
    }

    private bool _include_activation_code = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"include_activation_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool include_activation_code
    {
      get { return _include_activation_code; }
      set { _include_activation_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_SendEmail_Response")]
  public partial class CTwoFactor_SendEmail_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_SendEmail_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_FinalizeAddAuthenticator_Request")]
  public partial class CTwoFactor_FinalizeAddAuthenticator_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_FinalizeAddAuthenticator_Request() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private string _authenticator_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"authenticator_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string authenticator_code
    {
      get { return _authenticator_code; }
      set { _authenticator_code = value; }
    }

    private ulong _authenticator_time = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"authenticator_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong authenticator_time
    {
      get { return _authenticator_time; }
      set { _authenticator_time = value; }
    }

    private string _activation_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"activation_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string activation_code
    {
      get { return _activation_code; }
      set { _activation_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_FinalizeAddAuthenticator_Response")]
  public partial class CTwoFactor_FinalizeAddAuthenticator_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_FinalizeAddAuthenticator_Response() {}
    

    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }

    private bool _want_more = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"want_more", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool want_more
    {
      get { return _want_more; }
      set { _want_more = value; }
    }

    private ulong _server_time = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"server_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong server_time
    {
      get { return _server_time; }
      set { _server_time = value; }
    }

    private int _status = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_RemoveAuthenticator_Request")]
  public partial class CTwoFactor_RemoveAuthenticator_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_RemoveAuthenticator_Request() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private string _revocation_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"revocation_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string revocation_code
    {
      get { return _revocation_code; }
      set { _revocation_code = value; }
    }

    private string _authenticator_code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"authenticator_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string authenticator_code
    {
      get { return _authenticator_code; }
      set { _authenticator_code = value; }
    }

    private ulong _authenticator_time = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"authenticator_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong authenticator_time
    {
      get { return _authenticator_time; }
      set { _authenticator_time = value; }
    }

    private uint _revocation_reason = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"revocation_reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint revocation_reason
    {
      get { return _revocation_reason; }
      set { _revocation_reason = value; }
    }

    private uint _steamguard_scheme = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"steamguard_scheme", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint steamguard_scheme
    {
      get { return _steamguard_scheme; }
      set { _steamguard_scheme = value; }
    }

    private bool _remove_all_steamguard_cookies = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"remove_all_steamguard_cookies", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool remove_all_steamguard_cookies
    {
      get { return _remove_all_steamguard_cookies; }
      set { _remove_all_steamguard_cookies = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_RemoveAuthenticator_Response")]
  public partial class CTwoFactor_RemoveAuthenticator_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_RemoveAuthenticator_Response() {}
    

    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }

    private bool _want_more = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"want_more", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool want_more
    {
      get { return _want_more; }
      set { _want_more = value; }
    }

    private ulong _server_time = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"server_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong server_time
    {
      get { return _server_time; }
      set { _server_time = value; }
    }

    private int _status = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_CreateEmergencyCodes_Request")]
  public partial class CTwoFactor_CreateEmergencyCodes_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_CreateEmergencyCodes_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_CreateEmergencyCodes_Response")]
  public partial class CTwoFactor_CreateEmergencyCodes_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_CreateEmergencyCodes_Response() {}
    
    private readonly global::System.Collections.Generic.List<string> _codes = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"codes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> codes
    {
      get { return _codes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_DestroyEmergencyCodes_Request")]
  public partial class CTwoFactor_DestroyEmergencyCodes_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_DestroyEmergencyCodes_Request() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_DestroyEmergencyCodes_Response")]
  public partial class CTwoFactor_DestroyEmergencyCodes_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_DestroyEmergencyCodes_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_ValidateToken_Request")]
  public partial class CTwoFactor_ValidateToken_Request : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_ValidateToken_Request() {}
    

    private string _code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CTwoFactor_ValidateToken_Response")]
  public partial class CTwoFactor_ValidateToken_Response : global::ProtoBuf.IExtensible
  {
    public CTwoFactor_ValidateToken_Response() {}
    

    private bool _valid = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool valid
    {
      get { return _valid; }
      set { _valid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ITwoFactor
    {
      CTwoFactor_Status_Response QueryStatus(CTwoFactor_Status_Request request);
    CTwoFactor_AddAuthenticator_Response AddAuthenticator(CTwoFactor_AddAuthenticator_Request request);
    CTwoFactor_SendEmail_Response SendEmail(CTwoFactor_SendEmail_Request request);
    CTwoFactor_FinalizeAddAuthenticator_Response FinalizeAddAuthenticator(CTwoFactor_FinalizeAddAuthenticator_Request request);
    CTwoFactor_RemoveAuthenticator_Response RemoveAuthenticator(CTwoFactor_RemoveAuthenticator_Request request);
    CTwoFactor_CreateEmergencyCodes_Response CreateEmergencyCodes(CTwoFactor_CreateEmergencyCodes_Request request);
    CTwoFactor_DestroyEmergencyCodes_Response DestroyEmergencyCodes(CTwoFactor_DestroyEmergencyCodes_Request request);
    CTwoFactor_ValidateToken_Response ValidateToken(CTwoFactor_ValidateToken_Request request);
    
    }
    
    
}
#pragma warning restore 1591
