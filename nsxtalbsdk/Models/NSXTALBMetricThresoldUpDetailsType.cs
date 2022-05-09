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
    public class NSXTALBMetricThresoldUpDetailsType 
    {
        /// <summary>
        /// Placeholder for description of property current_value of obj type MetricThresoldUpDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "current_value")]
        public double? CurrentValue { get; set; }
        /// <summary>
        /// ID of the object whose metric has hit the threshold.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// metric_id of MetricThresoldUpDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// metric_name of MetricThresoldUpDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metric_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricName { get; set; }
        /// <summary>
        /// Identity of the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Server IP Port on which event was generated.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Placeholder for description of property threshold of obj type MetricThresoldUpDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public double? Threshold { get; set; }
    }
}
