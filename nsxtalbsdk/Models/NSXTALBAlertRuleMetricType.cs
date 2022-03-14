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
    public class NSXTALBAlertRuleMetricType 
    {
        /// <summary>
        /// Evaluation window for the Metrics. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Metric Id for the Alert. Eg. l4_client.avg_complete_conns.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// Placeholder for description of property metric_threshold of obj type AlertRuleMetric field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "metric_threshold", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBAlertMetricThresholdType MetricThreshold { get; set; }
    }
}
