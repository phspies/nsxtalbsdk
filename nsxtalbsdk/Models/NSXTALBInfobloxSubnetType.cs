using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBInfobloxSubnetType
    {
        /// <summary>
        /// IPv4 subnet to use for Infoblox allocation. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// IPv6 subnet to use for Infoblox allocation. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
    }
}
