using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPoolAnomalyScoreDataType
    {
        /// <summary>
        /// anomalous_l4_metrics of PoolAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_l4_metrics")]
        public IList<string> AnomalousL4Metrics { get; set; }
        /// <summary>
        /// anomalous_l7_metrics of PoolAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_l7_metrics")]
        public IList<string> AnomalousL7Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_server_anomaly_score of obj type PoolAnomalyScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_server_anomaly_score")]
        public double? AvgServerAnomalyScore { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_l4_metrics of obj type PoolAnomalyScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_l4_metrics")]
        [System.ComponentModel.DataAnnotations.Required]
        public double PerAnomalousL4Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_l7_metrics of obj type PoolAnomalyScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_l7_metrics")]
        public double? PerAnomalousL7Metrics { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolRef { get; set; }
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property server_anomaly_scores of obj type PoolAnomalyScoreData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_anomaly_scores")]
        public IList<NSXTALBServerAnomalyScoreType> ServerAnomalyScores { get; set; }
    }
}
