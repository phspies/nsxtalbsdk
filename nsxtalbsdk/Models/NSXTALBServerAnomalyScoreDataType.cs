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
    public class NSXTALBServerAnomalyScoreDataType 
    {
        /// <summary>
        /// anomalous_l4_metrics of ServerAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_l4_metrics")]
        public IList<string> AnomalousL4Metrics { get; set; }
        /// <summary>
        /// anomalous_l7_metrics of ServerAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_l7_metrics")]
        public IList<string> AnomalousL7Metrics { get; set; }
        /// <summary>
        /// anomalous_vm_metrics of ServerAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "anomalous_vm_metrics")]
        public IList<string> AnomalousVmMetrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_l4_metrics of obj type ServerAnomalyScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_l4_metrics")]
        [System.ComponentModel.DataAnnotations.Required]
        public double PerAnomalousL4Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_l7_metrics of obj type ServerAnomalyScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_l7_metrics")]
        public double? PerAnomalousL7Metrics { get; set; }
        /// <summary>
        /// Placeholder for description of property per_anomalous_vm_metrics of obj type ServerAnomalyScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "per_anomalous_vm_metrics")]
        public double? PerAnomalousVmMetrics { get; set; }
        /// <summary>
        /// Unique object identifier of pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolUuid { get; set; }
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
        /// server of ServerAnomalyScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Server { get; set; }
    }
}
