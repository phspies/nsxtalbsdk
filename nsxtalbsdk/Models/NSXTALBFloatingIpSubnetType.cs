using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBFloatingIpSubnetType
    {
        /// <summary>
        /// FloatingIp subnet name if available, else uuid. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// FloatingIp subnet prefix. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public NSXTALBIpAddrPrefixType Prefix { get; set; }
        /// <summary>
        /// FloatingIp subnet uuid. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
