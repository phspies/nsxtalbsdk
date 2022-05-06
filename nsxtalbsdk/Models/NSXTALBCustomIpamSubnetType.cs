using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCustomIpamSubnetType
    {
        /// <summary>
        /// Network to use for Custom IPAM IP allocation. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "network_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NetworkId { get; set; }
        /// <summary>
        /// IPv4 subnet to use for Custom IPAM IP allocation. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// IPv6 subnet to use for Custom IPAM IP allocation. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
    }
}
