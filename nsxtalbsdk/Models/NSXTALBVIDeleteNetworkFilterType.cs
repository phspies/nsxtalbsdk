using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIDeleteNetworkFilterType
    {
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        public string? Datacenter { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuid")]
        public string? NetworkUuid { get; set; }
        /// <summary>
        /// Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        public string? VcenterUrl { get; set; }
    }
}
