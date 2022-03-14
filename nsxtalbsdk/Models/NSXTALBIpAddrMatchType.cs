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
    public class NSXTALBIpAddrMatchType 
    {
        /// <summary>
        /// IP address(es).
        /// </summary>
        [JsonProperty(PropertyName = "addrs")]
        public IList<NSXTALBIpAddrType> Addrs { get; set; }
        /// <summary>
        /// UUID of IP address group(s). It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "group_refs")]
        public IList<string> GroupRefs { get; set; }
        /// <summary>
        /// Criterion to use for IP address matching the HTTP request. Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// IP address prefix(es).
        /// </summary>
        [JsonProperty(PropertyName = "prefixes")]
        public IList<NSXTALBIpAddrPrefixType> Prefixes { get; set; }
        /// <summary>
        /// IP address range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBIpAddrRangeType> Ranges { get; set; }
    }
}
