using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVipAutoscalePolicyType
    {
        /// <summary>
        /// The amount of time, in seconds, when a Vip is withdrawn before a scaling activity starts. Field introduced in 17.2.12,
        /// 18.1.2. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dns_cooldown")]
        public int? DnsCooldown { get; set; }
        /// <summary>
        /// The maximum size of the group. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "max_size")]
        public int? MaxSize { get; set; }
        /// <summary>
        /// The minimum size of the group. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "min_size")]
        public int? MinSize { get; set; }
        /// <summary>
        /// When set, scaling is suspended. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "suspend")]
        public bool? Suspend { get; set; }
    }
}
