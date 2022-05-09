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
    public class NSXTALBGslbPoolType 
    {
        /// <summary>
        /// The load balancing algorithm will pick a local member within the GSLB service list of available Members. Enum options -
        /// GSLB_ALGORITHM_ROUND_ROBIN, GSLB_ALGORITHM_CONSISTENT_HASH, GSLB_ALGORITHM_GEO, GSLB_ALGORITHM_TOPOLOGY.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Algorithm { get; set; }
        /// <summary>
        /// Mask to be applied on client IP for consistent hash algorithm. Allowed values are 1-31.
        /// </summary>
        [JsonProperty(PropertyName = "consistent_hash_mask")]
        public int? ConsistentHashMask { get; set; }
        /// <summary>
        /// Mask to be applied on client IPV6 address for consistent hash algorithm. Allowed values are 1-127. Field introduced in
        /// 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "consistent_hash_mask6")]
        public int? ConsistentHashMask6 { get; set; }
        /// <summary>
        /// User provided information that records member details such as application owner name, contact, etc. Field introduced in
        /// 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable or disable a GSLB service pool. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The fallback load balancing algorithm used to pick a member when the pool algorithm fails to find a valid member. For
        /// instance when algorithm is Geo and client/server do not have valid geo location. Enum options -
        /// GSLB_ALGORITHM_ROUND_ROBIN, GSLB_ALGORITHM_CONSISTENT_HASH, GSLB_ALGORITHM_GEO, GSLB_ALGORITHM_TOPOLOGY. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_algorithm")]
        public string? FallbackAlgorithm { get; set; }
        /// <summary>
        /// Select list of VIPs belonging to this GSLB service. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTALBGslbPoolMemberType> Members { get; set; }
        /// <summary>
        /// Minimum number of health monitors in UP state to mark the member UP. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_health_monitors_up")]
        public int? MinHealthMonitorsUp { get; set; }
        /// <summary>
        /// Name of the GSLB service pool.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Priority of this pool of Members. The higher the number, the higher is the priority of the pool. The DNS Service chooses
        /// the pool with the highest priority that is operationally up. Allowed values are 0-100. Special values are 0 - Do not
        /// choose members from this pool.A priority of 0 is equivalent to disabling the pool..
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
    }
}
