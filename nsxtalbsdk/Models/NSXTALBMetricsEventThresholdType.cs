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
    public class NSXTALBMetricsEventThresholdType 
    {
        /// <summary>
        /// Type of the metrics event threshold. This value will decide which metric rule (or rules) use configured thresholds. Enum
        /// options - THRESHOLD_TYPE_STATIC, SE_CPU_THRESHOLD, SE_MEM_THRESHOLD, SE_DISK_THRESHOLD, CONTROLLER_CPU_THRESHOLD,
        /// CONTROLLER_MEM_THRESHOLD, CONTROLLER_DISK_THRESHOLD. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_event_threshold_type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricsEventThresholdType { get; set; }
        /// <summary>
        /// This value is used to reset the event state machine. Allowed values are 0-100. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reset_threshold")]
        public double? ResetThreshold { get; set; }
        /// <summary>
        /// Threshold value for which event in raised. There can be multiple thresholds defined.Health score degrades when the the
        /// target is higher than this threshold. Allowed values are 0-100. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "watermark_thresholds")]
        public int? WatermarkThresholds { get; set; }
    }
}
