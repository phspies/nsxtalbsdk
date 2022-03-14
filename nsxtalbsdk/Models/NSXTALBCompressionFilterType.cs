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
    public class NSXTALBCompressionFilterType 
    {
        /// <summary>
        /// It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "devices_ref")]
        public string? DevicesRef { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addr_prefixes of obj type CompressionFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr_prefixes")]
        public IList<NSXTALBIpAddrPrefixType> IpAddrPrefixes { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addr_ranges of obj type CompressionFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr_ranges")]
        public IList<NSXTALBIpAddrRangeType> IpAddrRanges { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_addrs of obj type CompressionFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_addrs")]
        public IList<NSXTALBIpAddrType> IpAddrs { get; set; }
        /// <summary>
        /// It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addrs_ref")]
        public string? IpAddrsRef { get; set; }
        /// <summary>
        /// Enum options - AGGRESSIVE_COMPRESSION, NORMAL_COMPRESSION, NO_COMPRESSION.
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Level { get; set; }
        /// <summary>
        /// Whether to apply Filter when group criteria is matched or not. Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public string? Match { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// user_agent of CompressionFilter.
        /// </summary>
        [JsonProperty(PropertyName = "user_agent")]
        public IList<string> UserAgent { get; set; }
    }
}
