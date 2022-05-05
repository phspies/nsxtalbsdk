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
    public class NSXTALBDnsRateLimiterType 
    {
        /// <summary>
        /// Action to perform upon rate limiting. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBDnsRuleRLActionType Action { get; set; }
        /// <summary>
        /// Rate limiting object. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rate_limiter_object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRateLimiterType RateLimiterObject { get; set; }
    }
}
