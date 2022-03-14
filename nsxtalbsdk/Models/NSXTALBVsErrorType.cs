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
    public class NSXTALBVsErrorType 
    {
        /// <summary>
        /// The time at which the error occurred. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "event_timestamp")]
        public NSXTALBTimeStampType EventTimestamp { get; set; }
        /// <summary>
        /// reason of VsError.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public IList<string> Reason { get; set; }
        /// <summary>
        /// Enum options - HA_MODE_SHARED_PAIR, HA_MODE_SHARED, HA_MODE_LEGACY_ACTIVE_STANDBY.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ha_mode")]
        public string? SeGroupHaMode { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngineGroup.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        public string? SeGroupRef { get; set; }
        /// <summary>
        /// The SE on which the VS errored during scale-in/scale-out operations. It is a reference to an object of type
        /// ServiceEngine. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Enum options - TRAFFIC_DISRUPTED, TRAFFIC_NOT_DISRUPTED.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_status")]
        public string? TrafficStatus { get; set; }
        /// <summary>
        /// vip_id of VsError.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_ref")]
        public string? VsRef { get; set; }
    }
}
