using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDebugVirtualServiceType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Placeholder for description of property capture of obj type DebugVirtualService field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "capture")]
        public bool? Capture { get; set; }
        /// <summary>
        /// Per packet capture filters for Debug Virtual Service. Applies to both frontend and backend packets. Field introduced in
        /// 18.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "capture_filters")]
        public NSXTALBCaptureFiltersType CaptureFilters { get; set; }
        /// <summary>
        /// Placeholder for description of property capture_params of obj type DebugVirtualService field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "capture_params")]
        public NSXTALBDebugVirtualServiceCaptureType CaptureParams { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// This option controls the capture of Health Monitor flows. Enum options - DEBUG_VS_HM_NONE, DEBUG_VS_HM_ONLY,
        /// DEBUG_VS_HM_INCLUDE.
        /// </summary>
        [JsonProperty(PropertyName = "debug_hm")]
        public string? DebugHm { get; set; }
        /// <summary>
        /// Filters all packets of a complete transaction (client and server side), based on client ip.
        /// </summary>
        [JsonProperty(PropertyName = "debug_ip")]
        public NSXTALBDebugIpAddrType DebugIp { get; set; }
        /// <summary>
        /// Dns debug options. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_options")]
        public NSXTALBDebugDnsOptionsType DnsOptions { get; set; }
        /// <summary>
        /// Placeholder for description of property flags of obj type DebugVirtualService field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public IList<NSXTALBDebugVsDataplaneType> Flags { get; set; }
        /// <summary>
        /// Filters for latency audit. Supported only for ingress. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "latency_audit_filters")]
        public NSXTALBCaptureFiltersType LatencyAuditFilters { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Object sync debug options. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "objsync")]
        public NSXTALBDebugVirtualServiceObjSyncType Objsync { get; set; }
        /// <summary>
        /// This option re-synchronizes flows between Active-Standby service engines for all the virtual services placed on them. It
        /// should be used with caution because as it can cause a flood between Active-Standby. Field introduced in 18.1.3,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "resync_flows")]
        public bool? ResyncFlows { get; set; }
        /// <summary>
        /// Placeholder for description of property se_params of obj type DebugVirtualService field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_params")]
        public NSXTALBDebugVirtualServiceSeParamsType SeParams { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
