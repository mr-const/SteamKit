// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: steammessages_datapublisher.steamclient.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Unified.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CDataPublisher_ClientContentCorruptionReport_Notification : global::ProtoBuf.IExtensible
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
        public uint depotid
        {
            get { return __pbn__depotid.GetValueOrDefault(); }
            set { __pbn__depotid = value; }
        }
        public bool ShouldSerializedepotid() => __pbn__depotid != null;
        public void Resetdepotid() => __pbn__depotid = null;
        private uint? __pbn__depotid;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string download_source
        {
            get { return __pbn__download_source ?? ""; }
            set { __pbn__download_source = value; }
        }
        public bool ShouldSerializedownload_source() => __pbn__download_source != null;
        public void Resetdownload_source() => __pbn__download_source = null;
        private string __pbn__download_source;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string objectid
        {
            get { return __pbn__objectid ?? ""; }
            set { __pbn__objectid = value; }
        }
        public bool ShouldSerializeobjectid() => __pbn__objectid != null;
        public void Resetobjectid() => __pbn__objectid = null;
        private string __pbn__objectid;

        [global::ProtoBuf.ProtoMember(5)]
        public uint cellid
        {
            get { return __pbn__cellid.GetValueOrDefault(); }
            set { __pbn__cellid = value; }
        }
        public bool ShouldSerializecellid() => __pbn__cellid != null;
        public void Resetcellid() => __pbn__cellid = null;
        private uint? __pbn__cellid;

        [global::ProtoBuf.ProtoMember(6)]
        public bool is_manifest
        {
            get { return __pbn__is_manifest.GetValueOrDefault(); }
            set { __pbn__is_manifest = value; }
        }
        public bool ShouldSerializeis_manifest() => __pbn__is_manifest != null;
        public void Resetis_manifest() => __pbn__is_manifest = null;
        private bool? __pbn__is_manifest;

        [global::ProtoBuf.ProtoMember(7)]
        public ulong object_size
        {
            get { return __pbn__object_size.GetValueOrDefault(); }
            set { __pbn__object_size = value; }
        }
        public bool ShouldSerializeobject_size() => __pbn__object_size != null;
        public void Resetobject_size() => __pbn__object_size = null;
        private ulong? __pbn__object_size;

        [global::ProtoBuf.ProtoMember(8)]
        public uint corruption_type
        {
            get { return __pbn__corruption_type.GetValueOrDefault(); }
            set { __pbn__corruption_type = value; }
        }
        public bool ShouldSerializecorruption_type() => __pbn__corruption_type != null;
        public void Resetcorruption_type() => __pbn__corruption_type = null;
        private uint? __pbn__corruption_type;

        [global::ProtoBuf.ProtoMember(9)]
        public bool used_https
        {
            get { return __pbn__used_https.GetValueOrDefault(); }
            set { __pbn__used_https = value; }
        }
        public bool ShouldSerializeused_https() => __pbn__used_https != null;
        public void Resetused_https() => __pbn__used_https = null;
        private bool? __pbn__used_https;

        [global::ProtoBuf.ProtoMember(10)]
        public bool oc_proxy_detected
        {
            get { return __pbn__oc_proxy_detected.GetValueOrDefault(); }
            set { __pbn__oc_proxy_detected = value; }
        }
        public bool ShouldSerializeoc_proxy_detected() => __pbn__oc_proxy_detected != null;
        public void Resetoc_proxy_detected() => __pbn__oc_proxy_detected = null;
        private bool? __pbn__oc_proxy_detected;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CValveHWSurvey_GetSurveySchedule_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string surveydatetoken
        {
            get { return __pbn__surveydatetoken ?? ""; }
            set { __pbn__surveydatetoken = value; }
        }
        public bool ShouldSerializesurveydatetoken() => __pbn__surveydatetoken != null;
        public void Resetsurveydatetoken() => __pbn__surveydatetoken = null;
        private string __pbn__surveydatetoken;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong surveydatetokenversion
        {
            get { return __pbn__surveydatetokenversion.GetValueOrDefault(); }
            set { __pbn__surveydatetokenversion = value; }
        }
        public bool ShouldSerializesurveydatetokenversion() => __pbn__surveydatetokenversion != null;
        public void Resetsurveydatetokenversion() => __pbn__surveydatetokenversion = null;
        private ulong? __pbn__surveydatetokenversion;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CValveHWSurvey_GetSurveySchedule_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint surveydatetoken
        {
            get { return __pbn__surveydatetoken.GetValueOrDefault(); }
            set { __pbn__surveydatetoken = value; }
        }
        public bool ShouldSerializesurveydatetoken() => __pbn__surveydatetoken != null;
        public void Resetsurveydatetoken() => __pbn__surveydatetoken = null;
        private uint? __pbn__surveydatetoken;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong surveydatetokenversion
        {
            get { return __pbn__surveydatetokenversion.GetValueOrDefault(); }
            set { __pbn__surveydatetokenversion = value; }
        }
        public bool ShouldSerializesurveydatetokenversion() => __pbn__surveydatetokenversion != null;
        public void Resetsurveydatetokenversion() => __pbn__surveydatetokenversion = null;
        private ulong? __pbn__surveydatetokenversion;

    }

    public interface IDataPublisher
    {
        NoResponse ClientContentCorruptionReport(CDataPublisher_ClientContentCorruptionReport_Notification request);
    }

    public interface IValveHWSurvey
    {
        CValveHWSurvey_GetSurveySchedule_Response GetSurveySchedule(CValveHWSurvey_GetSurveySchedule_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
