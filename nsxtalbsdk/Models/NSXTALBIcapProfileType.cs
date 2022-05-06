using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIcapProfileType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Allow ICAP server to send 204 response as described in RFC 3507 section 4.5. Service Engine will buffer the complete
        /// request if alllow_204 is enabled. If disabled, preview_size request body will be buffered if enable_preview is set to
        /// true, and rest of the request body will be streamed to the ICAP server. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "allow_204")]
        public bool? Allow204 { get; set; }
        /// <summary>
        /// The maximum buffer size for the HTTP request body. If the request body exceeds this size, the request will not be
        /// checked by the ICAP server. In this case, the configured action will be executed and a significant log entry will be
        /// generated. Allowed values are 1-51200. Field introduced in 20.1.1. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "buffer_size")]
        public int? BufferSize { get; set; }
        /// <summary>
        /// Decide what should happen if the request body size exceeds the configured buffer size. If this is set to Fail Open, the
        /// request will not be checked by the ICAP server. If this is set to Fail Closed, the request will be rejected with 413
        /// status code. Enum options - ICAP_FAIL_OPEN, ICAP_FAIL_CLOSED. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "buffer_size_exceed_action")]
        public string? BufferSizeExceedAction { get; set; }
        /// <summary>
        /// The cloud where this object belongs to. This must match the cloud referenced in the pool group below. It is a reference
        /// to an object of type Cloud. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// A description for this ICAP profile. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Use the ICAP preview feature as described in RFC 3507 section 4.5. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_preview")]
        public bool? EnablePreview { get; set; }
        /// <summary>
        /// Decide what should happen if there is a problem with the ICAP server like communication timeout, protocol error, pool
        /// error, etc. If this is set to Fail Open, the request will continue, but will create a significant log entry. If this is
        /// set to Fail Closed, the request will be rejected with a 500 status code. Enum options - ICAP_FAIL_OPEN,
        /// ICAP_FAIL_CLOSED. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fail_action")]
        public string? FailAction { get; set; }
        /// <summary>
        /// Name of the ICAP profile. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// NSXDefender specific ICAP configurations. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsx_defender_config")]
        public NSXTALBIcapNsxDefenderConfigType NsxDefenderConfig { get; set; }
        /// <summary>
        /// The pool group which is used to connect to ICAP servers. It is a reference to an object of type PoolGroup. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolGroupRef { get; set; }
        /// <summary>
        /// The ICAP preview size as described in RFC 3507 section 4.5. This should not exceed the size supported by the ICAP
        /// server. If this is set to 0, only the HTTP header will be sent to the ICAP server as a preview. To disable preview
        /// completely, set the enable-preview option to false.If vendor is LASTLINE, recommended preview size is 1000 bytes,minimum
        /// preview size is 10 bytes. Allowed values are 0-5000. Field introduced in 20.1.1. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "preview_size")]
        public int? PreviewSize { get; set; }
        /// <summary>
        /// Maximum time, client's request will be paused for ICAP processing. If this timeout is exceeded, the request to the ICAP
        /// server will be aborted and the configured fail action is executed. Allowed values are 50-3600000. Field introduced in
        /// 20.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "response_timeout")]
        public int? ResponseTimeout { get; set; }
        /// <summary>
        /// The path and query component of the ICAP URL. Host name and port will be taken from the pool. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_uri")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServiceUri { get; set; }
        /// <summary>
        /// If the ICAP request takes longer than this value, this request will generate a significant log entry. Allowed values are
        /// 50-3600000. Field introduced in 20.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "slow_response_warning_threshold")]
        public int? SlowResponseWarningThreshold { get; set; }
        /// <summary>
        /// Tenant which this object belongs to. It is a reference to an object of type Tenant. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the ICAP profile. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// The vendor of the ICAP server. Enum options - ICAP_VENDOR_GENERIC, ICAP_VENDOR_OPSWAT, ICAP_VENDOR_LASTLINE. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string? Vendor { get; set; }
    }
}
