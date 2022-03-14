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
    public class NSXTALBPGDeploymentRuleResultType 
    {
        /// <summary>
        /// Metric value that is used as the pass fail. If it is not provided then it will simply compare it with current pool vs
        /// new pool.
        /// </summary>
        [JsonProperty(PropertyName = "metric_value")]
        public double? MetricValue { get; set; }
        /// <summary>
        /// Whether rule passed or failed.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public bool? Result { get; set; }
        /// <summary>
        /// Rule used for evaluation.
        /// </summary>
        [JsonProperty(PropertyName = "rule", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBPGDeploymentRuleType Rule { get; set; }
    }
}
