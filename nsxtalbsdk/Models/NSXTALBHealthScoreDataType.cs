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
    public class NSXTALBHealthScoreDataType 
    {
        /// <summary>
        /// Number of anomaly_penalty.
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_penalty")]
        public int? AnomalyPenalty { get; set; }
        /// <summary>
        /// Placeholder for description of property anomaly_score of obj type HealthScoreData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_score")]
        public NSXTALBHealthScoreAnomalyDataType AnomalyScore { get; set; }
        /// <summary>
        /// Placeholder for description of property dos_attack_level of obj type HealthScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "dos_attack_level")]
        public double? DosAttackLevel { get; set; }
        /// <summary>
        /// This is set if the data is none or zero is none.
        /// </summary>
        [JsonProperty(PropertyName = "is_null")]
        public bool? IsNull { get; set; }
        /// <summary>
        /// This keeps the num samples reported during aggregation queries.
        /// </summary>
        [JsonProperty(PropertyName = "num_samples")]
        public int? NumSamples { get; set; }
        /// <summary>
        /// Placeholder for description of property performance_score of obj type HealthScoreData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "performance_score")]
        public NSXTALBHealthScorePerformanceDataType PerformanceScore { get; set; }
        /// <summary>
        /// Number of performance_value.
        /// </summary>
        [JsonProperty(PropertyName = "performance_value")]
        public int? PerformanceValue { get; set; }
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
        /// Number of resources_penalty.
        /// </summary>
        [JsonProperty(PropertyName = "resources_penalty")]
        public int? ResourcesPenalty { get; set; }
        /// <summary>
        /// Placeholder for description of property resources_score of obj type HealthScoreData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "resources_score")]
        public NSXTALBHealthScoreResourcesDataType ResourcesScore { get; set; }
        /// <summary>
        /// Number of security_penalty.
        /// </summary>
        [JsonProperty(PropertyName = "security_penalty")]
        public int? SecurityPenalty { get; set; }
        /// <summary>
        /// Placeholder for description of property security_threat_level of obj type HealthScoreData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "security_threat_level")]
        public NSXTALBHealthScoreSecurityDataType SecurityThreatLevel { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_score of obj type HealthScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "ssl_score")]
        public double? SslScore { get; set; }
        /// <summary>
        /// timestamp of HealthScoreData.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type HealthScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
