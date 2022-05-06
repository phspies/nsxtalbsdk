using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPGDeploymentRuleType
    {
        /// <summary>
        /// metric_id of PGDeploymentRule.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// Enum options - CO_EQ, CO_GT, CO_GE, CO_LT, CO_LE, CO_NE.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string? OperatorProperty { get; set; }
        /// <summary>
        /// metric threshold that is used as the pass fail. If it is not provided then it will simply compare it with current pool
        /// vs new pool.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public double? Threshold { get; set; }
    }
}
