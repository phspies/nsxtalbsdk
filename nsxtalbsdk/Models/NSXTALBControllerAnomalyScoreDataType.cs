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
    public class NSXTALBControllerAnomalyScoreDataType 
    {
        /// <summary>
        /// anomalous_controller_stats_metrics of ControllerAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_controller_stats_metrics")]
        public IList<string> AnomalousControllerStatsMetrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_controller_stats_metrics of obj type ControllerAnomalyScoreData
        /// field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_controller_stats_metrics", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double PerAnomalousControllerStatsMetrics { get; set; }
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
