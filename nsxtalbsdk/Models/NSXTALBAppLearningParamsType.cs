using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAppLearningParamsType
    {
        /// <summary>
        /// Learn the params per URI path. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_per_uri_learning")]
        public bool? EnablePerUriLearning { get; set; }
        /// <summary>
        /// Maximum number of params programmed for an application. Allowed values are 10-1000. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_params")]
        public int? MaxParams { get; set; }
        /// <summary>
        /// Maximum number of URI paths programmed for an application. Allowed values are 10-10000. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "max_uris")]
        public int? MaxUris { get; set; }
        /// <summary>
        /// Minimum number of occurances required for a Param to qualify for learning. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "min_hits_to_learn")]
        public long? MinHitsToLearn { get; set; }
        /// <summary>
        /// Percent of the requests subjected to Application learning. Allowed values are 1-100. Field introduced in 18.2.3. Unit is
        /// PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_percent")]
        public int? SamplingPercent { get; set; }
        /// <summary>
        /// Frequency with which SE publishes Application learning data to controller. Allowed values are 1-60. Field introduced in
        /// 18.2.3. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "update_interval")]
        public int? UpdateInterval { get; set; }
    }
}
