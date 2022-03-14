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
    public class NSXTALBServiceEngineAnomalyScoreDataType 
    {
        public NSXTALBServiceEngineAnomalyScoreDataType()
        {
        }
        /// <summary>
        /// anomalous_se_stats_metrics of ServiceEngineAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_se_stats_metrics")]
        public IList<string> AnomalousSeStatsMetrics { get; set; }
        /// <summary>
        /// anomalous_vm_stats_metrics of ServiceEngineAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_vm_stats_metrics")]
        public IList<string> AnomalousVmStatsMetrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_se_stats_metrics of obj type ServiceEngineAnomalyScoreData field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_se_stats_metrics", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double PerAnomalousSeStatsMetrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_vm_stats_metrics of obj type ServiceEngineAnomalyScoreData field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_vm_stats_metrics")]
        public double? PerAnomalousVmStatsMetrics { get; set; }
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
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
    }
}
