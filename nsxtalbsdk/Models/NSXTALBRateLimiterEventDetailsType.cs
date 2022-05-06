using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRateLimiterEventDetailsType
    {
        /// <summary>
        /// Rate limiter error message. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Name of the rate limiter. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rl_resource_name")]
        public string? RlResourceName { get; set; }
        /// <summary>
        /// Rate limiter type. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rl_resource_type")]
        public string? RlResourceType { get; set; }
        /// <summary>
        /// Status. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
    }
}
