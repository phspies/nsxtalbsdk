using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRateProfileType
    {
        /// <summary>
        /// Action to perform upon rate limiting.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRateLimiterActionType Action { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets to be let through instantaneously. Allowed values are 10-2500.
        /// Special values are 0- automatic. Field deprecated in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "burst_sz")]
        public int? BurstSz { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets. Allowed values are 1-1000000000. Special values are 0- unlimited.
        /// Field deprecated in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Explicitly tracks an attacker across rate periods.
        /// </summary>
        [JsonProperty(PropertyName = "explicit_tracking")]
        public bool? ExplicitTracking { get; set; }
        /// <summary>
        /// Enable fine granularity.
        /// </summary>
        [JsonProperty(PropertyName = "fine_grain")]
        public bool? FineGrain { get; set; }
        /// <summary>
        /// HTTP cookie name. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_cookie")]
        public string? HttpCookie { get; set; }
        /// <summary>
        /// HTTP header name. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_header")]
        public string? HttpHeader { get; set; }
        /// <summary>
        /// Time value in seconds to enforce rate count. Allowed values are 1-300. Field deprecated in 18.2.9. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public int? Period { get; set; }
        /// <summary>
        /// The rate limiter configuration for this rate profile. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter")]
        public NSXTALBRateLimiterType RateLimiter { get; set; }
    }
}
