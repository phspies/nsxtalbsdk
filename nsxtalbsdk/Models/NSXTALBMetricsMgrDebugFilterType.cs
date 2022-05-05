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
    public class NSXTALBMetricsMgrDebugFilterType 
    {
        /// <summary>
        /// Set to ignore skip_eval_period field in metrics_anomaly_option. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "debug_skip_eval_period")]
        public string? DebugSkipEvalPeriod { get; set; }
        /// <summary>
        /// disable_hw_training of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "disable_hw_training")]
        public string? DisableHwTraining { get; set; }
        /// <summary>
        /// entity of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "entity")]
        public string? Entity { get; set; }
        /// <summary>
        /// setting to reduce the grace period for license expiry in hours.
        /// </summary>
        [JsonProperty(PropertyName = "license_grace_period")]
        public string? LicenseGracePeriod { get; set; }
        /// <summary>
        /// log_first_n of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "log_first_n")]
        public string? LogFirstN { get; set; }
        /// <summary>
        /// logging_freq of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "logging_freq")]
        public string? LoggingFreq { get; set; }
        /// <summary>
        /// metric_instance_id of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "metric_instance_id")]
        public string? MetricInstanceId { get; set; }
        /// <summary>
        /// obj of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "obj")]
        public string? Obj { get; set; }
        /// <summary>
        /// skip_cluster_map_check of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "skip_cluster_map_check")]
        public string? SkipClusterMapCheck { get; set; }
        /// <summary>
        /// skip_metrics_db_writes of MetricsMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "skip_metrics_db_writes")]
        public string? SkipMetricsDbWrites { get; set; }
    }
}
