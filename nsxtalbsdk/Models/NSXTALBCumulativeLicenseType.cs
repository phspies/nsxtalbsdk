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
    public class NSXTALBCumulativeLicenseType 
    {
        /// <summary>
        /// Total number of Service Engine cores for burst core based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "burst_cores")]
        public int? BurstCores { get; set; }
        /// <summary>
        /// Total number of Service Engine cores for core based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public int? Cores { get; set; }
        /// <summary>
        /// Total number of Service Engines for host based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "max_ses")]
        public int? MaxSes { get; set; }
        /// <summary>
        /// Service Engine bandwidth limits for bandwidth based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_bandwidth_limits")]
        public IList<NSXTALBSEBandwidthLimitType> SeBandwidthLimits { get; set; }
        /// <summary>
        /// Total number of Service Engine cores.. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_cores")]
        public double? ServiceCores { get; set; }
        /// <summary>
        /// Total number of Service Engine sockets for socket based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sockets")]
        public int? Sockets { get; set; }
        /// <summary>
        /// Specifies the licensed tier. Enum options - ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS. Field
        /// introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tier_type")]
        public string? TierType { get; set; }
    }
}
