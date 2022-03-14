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
    public class NSXTALBRateLimiterPropertiesType 
    {
        public NSXTALBRateLimiterPropertiesType()
        {
        }
        /// <summary>
        /// Number of stages in msf rate limiter. Allowed values are 1-2. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "msf_num_stages")]
        public int? MsfNumStages { get; set; }
        /// <summary>
        /// Each stage size in msf rate limiter. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "msf_stage_size")]
        public long? MsfStageSize { get; set; }
    }
}
