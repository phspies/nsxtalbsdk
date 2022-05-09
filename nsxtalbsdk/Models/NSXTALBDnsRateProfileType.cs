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
    public class NSXTALBDnsRateProfileType 
    {
        /// <summary>
        /// Action to perform upon rate limiting. Field deprecated in 20.1.1. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBDnsRuleRLActionType Action { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets to be rate limited instantaneously. Field deprecated in 20.1.1.
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        public int? BurstSize { get; set; }
        /// <summary>
        /// Maximum number of connections or requests or packets per second. It is deprecated because of adoption of new shared rate
        /// limiter protobuf. Allowed values are 1-4294967295. Special values are 0- unlimited. Field deprecated in 20.1.1. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Enable fine granularity. Field deprecated in 20.1.1. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "fine_grain")]
        public bool? FineGrain { get; set; }
        /// <summary>
        /// Time value in seconds to enforce rate count. Allowed values are 1-300. Field deprecated in 20.1.1. Field introduced in
        /// 18.2.5. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public int? Period { get; set; }
    }
}
