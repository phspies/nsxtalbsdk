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
    public class NSXTALBVirtualServiceAnomalyScoreDataType 
    {
        /// <summary>
        /// anomalous_l4_metrics of VirtualServiceAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_l4_metrics")]
        public IList<string> AnomalousL4Metrics { get; set; }
        /// <summary>
        /// anomalous_l7_metrics of VirtualServiceAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_l7_metrics")]
        public IList<string> AnomalousL7Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_l4_metrics of obj type VirtualServiceAnomalyScoreData field type
        /// str  type number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_l4_metrics")]
        public double? PerAnomalousL4Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_l7_metrics of obj type VirtualServiceAnomalyScoreData field type
        /// str  type number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_l7_metrics")]
        public double? PerAnomalousL7Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_anomaly_scores of obj type VirtualServiceAnomalyScoreData field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_anomaly_scores")]
        public IList<NSXTALBPoolAnomalyScoreType> PoolAnomalyScores { get; set; }
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
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property serviceengine_anomaly_scores of obj type VirtualServiceAnomalyScoreData field
        /// type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_anomaly_scores")]
        public IList<NSXTALBServiceEngineAnomalyScoreType> ServiceengineAnomalyScores { get; set; }
    }
}
