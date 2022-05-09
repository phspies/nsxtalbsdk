using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPSecurityActionRateProfileType 
    {
        /// <summary>
        /// The action to take when the rate limit has been reached. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRateLimiterActionType Action { get; set; }
        /// <summary>
        /// Rate limiting should be done on a per client ip basis. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "per_client_ip")]
        public bool? PerClientIp { get; set; }
        /// <summary>
        /// Rate limiting should be done on a per request uri path basis. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "per_uri_path")]
        public bool? PerUriPath { get; set; }
        /// <summary>
        /// The rate limiter used when this action is triggered. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRateLimiterType RateLimiter { get; set; }
    }
}
