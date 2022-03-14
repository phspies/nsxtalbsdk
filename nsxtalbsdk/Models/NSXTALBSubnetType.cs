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
    public class NSXTALBSubnetType 
    {
        public NSXTALBSubnetType()
        {
        }
        /// <summary>
        /// Specify an IP subnet prefix for this Network.
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Prefix { get; set; }
        /// <summary>
        /// Static IP ranges for this subnet. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "static_ip_ranges")]
        public IList<NSXTALBStaticIpRangeType> StaticIpRanges { get; set; }
        /// <summary>
        /// Use static_ip_ranges. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "static_ips")]
        public IList<NSXTALBIpAddrType> StaticIps { get; set; }
        /// <summary>
        /// Use static_ip_ranges. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "static_ranges")]
        public IList<NSXTALBIpAddrRangeType> StaticRanges { get; set; }
    }
}
