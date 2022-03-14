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
    public class NSXTALBIPAddrLimitsType 
    {
        public NSXTALBIPAddrLimitsType()
        {
        }
        /// <summary>
        /// Number of IP address groups for match criteria. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address_group_per_match_criteria")]
        public int? IpAddressGroupPerMatchCriteria { get; set; }
        /// <summary>
        /// Number of IP address prefixes for match criteria. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address_prefix_per_match_criteria")]
        public int? IpAddressPrefixPerMatchCriteria { get; set; }
        /// <summary>
        /// Number of IP address ranges for match criteria. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address_range_per_match_criteria")]
        public int? IpAddressRangePerMatchCriteria { get; set; }
        /// <summary>
        /// Number of IP addresses for match criteria. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses_per_match_criteria")]
        public int? IpAddressesPerMatchCriteria { get; set; }
    }
}
