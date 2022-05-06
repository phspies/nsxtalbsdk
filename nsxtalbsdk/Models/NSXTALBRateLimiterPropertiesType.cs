using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRateLimiterPropertiesType
    {
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
