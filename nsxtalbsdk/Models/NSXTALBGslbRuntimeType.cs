using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbRuntimeType 
    {
        public NSXTALBGslbRuntimeType()
        {
        }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string? Checksum { get; set; }
        /// <summary>
        /// This field indicates delete is in progress for this Gslb instance. . Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "delete_in_progress")]
        public bool? DeleteInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property dns_enabled of obj type GslbRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "dns_enabled")]
        public bool? DnsEnabled { get; set; }
        /// <summary>
        /// Placeholder for description of property event_cache of obj type GslbRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "event_cache")]
        public NSXTALBEventCacheType EventCache { get; set; }
        /// <summary>
        /// Placeholder for description of property flr_state of obj type GslbRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "flr_state")]
        public IList<NSXTALBCfgStateType> FlrState { get; set; }
        /// <summary>
        /// Placeholder for description of property ldr_state of obj type GslbRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ldr_state")]
        public NSXTALBCfgStateType LdrState { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property site of obj type GslbRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "site")]
        public IList<NSXTALBGslbSiteRuntimeType> Site { get; set; }
        /// <summary>
        /// Remap the tenant_uuid to its tenant-name so that we can use the tenant_name directly in remote-site ops. . Field
        /// introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name")]
        public string? TenantName { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "third_party_sites")]
        public IList<NSXTALBGslbThirdPartySiteRuntimeType> ThirdPartySites { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
