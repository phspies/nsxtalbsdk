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
    public class NSXTALBRateLimiterType 
    {
        /// <summary>
        /// Maximum number of connections, requests or packets to be let through instantaneously.  If this is less than count, it
        /// will have no effect. Allowed values are 0-1000000000. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "burst_sz")]
        public int? BurstSz { get; set; }
        /// <summary>
        /// Maximum number of connections, requests or packets permitted each period. Allowed values are 1-1000000000. Field
        /// introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Count { get; set; }
        /// <summary>
        /// Identifier for Rate Limit. Constructed according to context. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Time value in seconds to enforce rate count. Allowed values are 1-1000000000. Field introduced in 18.2.9. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Period { get; set; }
    }
}
