using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSEBandwidthLimitType
    {
        /// <summary>
        /// Total number of Service Engines for bandwidth based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Maximum bandwidth allowed by each Service Engine. Enum options - SE_BANDWIDTH_UNLIMITED, SE_BANDWIDTH_25M,
        /// SE_BANDWIDTH_200M, SE_BANDWIDTH_1000M, SE_BANDWIDTH_10000M. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
