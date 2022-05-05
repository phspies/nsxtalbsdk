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
    public class NSXTALBStaticIpRangeRuntimeType 
    {
        /// <summary>
        /// Allocated IPs. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "allocated_ips")]
        public IList<NSXTALBStaticIpAllocInfoType> AllocatedIps { get; set; }
        /// <summary>
        /// Free IP count. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "free_ip_count")]
        public int? FreeIpCount { get; set; }
        /// <summary>
        /// Total IP count. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "total_ip_count")]
        public int? TotalIpCount { get; set; }
        /// <summary>
        /// Object type (VIP only, Service Engine only, or both) which is using this IP group. Enum options - STATIC_IPS_FOR_SE,
        /// STATIC_IPS_FOR_VIP, STATIC_IPS_FOR_VIP_AND_SE. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
