using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNetworkSecurityPolicyActionRLParamType
    {
        /// <summary>
        /// Maximum number of connections or requests or packets to be rate limited instantaneously.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        [System.ComponentModel.DataAnnotations.Required]
        public int BurstSize { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets per second. Allowed values are 1-4294967295.
        /// </summary>
        [JsonProperty(PropertyName = "max_rate")]
        [System.ComponentModel.DataAnnotations.Required]
        public int MaxRate { get; set; }
    }
}
