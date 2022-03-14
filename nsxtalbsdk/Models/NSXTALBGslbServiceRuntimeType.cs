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
    public class NSXTALBGslbServiceRuntimeType 
    {
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string? Checksum { get; set; }
        /// <summary>
        /// Fully qualified domain name of the GslbService. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
        /// <summary>
        /// Placeholder for description of property flr_state of obj type GslbServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "flr_state")]
        public IList<NSXTALBCfgStateType> FlrState { get; set; }
        /// <summary>
        /// Placeholder for description of property groups of obj type GslbServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<NSXTALBGslbPoolRuntimeType> Groups { get; set; }
        /// <summary>
        /// Placeholder for description of property ldr_state of obj type GslbServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ldr_state")]
        public NSXTALBCfgStateType LdrState { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property oper_status of obj type GslbServiceRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "oper_status")]
        public NSXTALBOperationalStatusType OperStatus { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "send_event")]
        public bool? SendEvent { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "send_status")]
        public bool? SendStatus { get; set; }
        /// <summary>
        /// services_state of GslbServiceRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "services_state")]
        public string? ServicesState { get; set; }
        /// <summary>
        /// Gslb site persistence consolidated status . Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "sp_oper_status")]
        public NSXTALBOperationalStatusType SpOperStatus { get; set; }
        /// <summary>
        /// Tenant name (and not uuid) is required in logs/metrics generated by the SE. .
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name")]
        public string? TenantName { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
