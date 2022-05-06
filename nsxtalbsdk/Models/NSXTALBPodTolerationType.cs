using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPodTolerationType
    {
        /// <summary>
        /// Effect to match. Enum options - NO_SCHEDULE, PREFER_NO_SCHEDULE, NO_EXECUTE. Field introduced in 17.2.14, 18.1.5,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public string? Effect { get; set; }
        /// <summary>
        /// Key to match. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// Operator to match. Enum options - EQUAL, EXISTS. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string? OperatorProperty { get; set; }
        /// <summary>
        /// Pods that tolerate the taint with a specified toleration_seconds remain bound for the specified amount of time. Field
        /// introduced in 17.2.14, 18.1.5, 18.2.1. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "toleration_seconds")]
        public int? TolerationSeconds { get; set; }
        /// <summary>
        /// Value to match. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
