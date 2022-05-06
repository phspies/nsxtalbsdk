using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNatAddrInfoType
    {
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
