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
    public class NSXTALBHealthScoreDetailsType 
    {
        /// <summary>
        /// Number of anomaly_penalty.
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_penalty")]
        public int? AnomalyPenalty { get; set; }
        /// <summary>
        /// Reason for Anomaly Penalty.
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_reason")]
        public string? AnomalyReason { get; set; }
        /// <summary>
        /// Reason for Performance Score.
        /// </summary>
        [JsonProperty(PropertyName = "performance_reason")]
        public string? PerformanceReason { get; set; }
        /// <summary>
        /// Number of performance_score.
        /// </summary>
        [JsonProperty(PropertyName = "performance_score")]
        public int? PerformanceScore { get; set; }
        /// <summary>
        /// Placeholder for description of property previous_value of obj type HealthScoreDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "previous_value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double PreviousValue { get; set; }
        /// <summary>
        /// Reason for the Health Score Change.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Number of resources_penalty.
        /// </summary>
        [JsonProperty(PropertyName = "resources_penalty")]
        public int? ResourcesPenalty { get; set; }
        /// <summary>
        /// Reason for Resources Penalty.
        /// </summary>
        [JsonProperty(PropertyName = "resources_reason")]
        public string? ResourcesReason { get; set; }
        /// <summary>
        /// Number of security_penalty.
        /// </summary>
        [JsonProperty(PropertyName = "security_penalty")]
        public int? SecurityPenalty { get; set; }
        /// <summary>
        /// Reason for Security Threat Level.
        /// </summary>
        [JsonProperty(PropertyName = "security_reason")]
        public string? SecurityReason { get; set; }
        /// <summary>
        /// The step interval in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public int? Step { get; set; }
        /// <summary>
        /// Resource prefix containing entity information.
        /// </summary>
        [JsonProperty(PropertyName = "sub_resource_prefix")]
        public string? SubResourcePrefix { get; set; }
        /// <summary>
        /// timestamp of HealthScoreDetails.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Timestamp { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type HealthScoreDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
