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
    public class NSXTALBSubnetRuntimeType 
    {
        /// <summary>
        /// Moved to StaticIpRangeRuntime. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "free_ip_count")]
        public int? FreeIpCount { get; set; }
        /// <summary>
        /// Use allocated_ips in StaticIpRangeRuntime. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_alloced")]
        public IList<NSXTALBIpAllocInfoType> IpAlloced { get; set; }
        /// <summary>
        /// Static IP range runtime. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_range_runtimes")]
        public IList<NSXTALBStaticIpRangeRuntimeType> IpRangeRuntimes { get; set; }
        /// <summary>
        /// Placeholder for description of property prefix of obj type SubnetRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Prefix { get; set; }
        /// <summary>
        /// Moved to StaticIpRangeRuntime. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "total_ip_count")]
        public int? TotalIpCount { get; set; }
        /// <summary>
        /// Can be derived from total - free in StaticIpRangeRuntime. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "used_ip_count")]
        public int? UsedIpCount { get; set; }
    }
}
