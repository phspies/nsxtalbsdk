using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbClientIpAddrGroupType
    {
        /// <summary>
        /// Configure IP address(es). Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "addrs")]
        public IList<NSXTALBIpAddrType> Addrs { get; set; }
        /// <summary>
        /// Configure IP address prefix(es). Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "prefixes")]
        public IList<NSXTALBIpAddrPrefixType> Prefixes { get; set; }
        /// <summary>
        /// Configure IP address range(s). Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBIpAddrRangeType> Ranges { get; set; }
        /// <summary>
        /// Specify whether this client IP address range is public or private. Enum options - GSLB_IP_PUBLIC, GSLB_IP_PRIVATE. Field
        /// introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
