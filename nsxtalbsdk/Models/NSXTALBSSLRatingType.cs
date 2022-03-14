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
    public class NSXTALBSSLRatingType 
    {
        public NSXTALBSSLRatingType()
        {
        }
        /// <summary>
        /// Enum options - SSL_SCORE_NOT_SECURE, SSL_SCORE_VERY_BAD, SSL_SCORE_BAD, SSL_SCORE_AVERAGE, SSL_SCORE_GOOD,
        /// SSL_SCORE_EXCELLENT.
        /// </summary>
        [JsonProperty(PropertyName = "compatibility_rating")]
        public string? CompatibilityRating { get; set; }
        /// <summary>
        /// Enum options - SSL_SCORE_NOT_SECURE, SSL_SCORE_VERY_BAD, SSL_SCORE_BAD, SSL_SCORE_AVERAGE, SSL_SCORE_GOOD,
        /// SSL_SCORE_EXCELLENT.
        /// </summary>
        [JsonProperty(PropertyName = "performance_rating")]
        public string? PerformanceRating { get; set; }
        /// <summary>
        /// security_score of SSLRating.
        /// </summary>
        [JsonProperty(PropertyName = "security_score")]
        public string? SecurityScore { get; set; }
    }
}
