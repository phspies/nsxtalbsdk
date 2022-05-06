using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDosRateLimitProfileType
    {
        /// <summary>
        /// Profile for DoS attack detection.
        /// </summary>
        [JsonProperty(PropertyName = "dos_profile")]
        public NSXTALBDosThresholdProfileType DosProfile { get; set; }
        /// <summary>
        /// Profile for Connections/Requests rate limiting.
        /// </summary>
        [JsonProperty(PropertyName = "rl_profile")]
        public NSXTALBRateLimiterProfileType RlProfile { get; set; }
    }
}
