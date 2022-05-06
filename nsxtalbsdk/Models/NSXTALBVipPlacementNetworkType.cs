using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVipPlacementNetworkType
    {
        /// <summary>
        /// Network to use for vip placement. It is a reference to an object of type Network. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// IPv4 Subnet to use for vip placement. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// IPv6 subnet to use for vip placement. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
    }
}
