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
    public class NSXTALBNatAddrInfoType 
    {
        public NSXTALBNatAddrInfoType()
        {
        }
        /// <summary>
        /// Nat IP address. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "nat_ip")]
        public NSXTALBIpAddrType NatIp { get; set; }
        /// <summary>
        /// Nat IP address range. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "nat_ip_range")]
        public NSXTALBIpAddrRangeType NatIpRange { get; set; }
    }
}
