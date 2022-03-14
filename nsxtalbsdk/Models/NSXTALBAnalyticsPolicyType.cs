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
    public class NSXTALBAnalyticsPolicyType 
    {
        /// <summary>
        /// Log all headers. Field introduced in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// Gain insights from sampled client to server HTTP requests and responses. Enum options - NO_INSIGHTS, PASSIVE, ACTIVE.
        /// </summary>
        [JsonProperty(PropertyName = "client_insights")]
        public string? ClientInsights { get; set; }
        /// <summary>
        /// Placeholder for description of property client_insights_sampling of obj type AnalyticsPolicy field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "client_insights_sampling")]
        public NSXTALBClientInsightsSamplingType ClientInsightsSampling { get; set; }
        /// <summary>
        /// Placeholder for description of property client_log_filters of obj type AnalyticsPolicy field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "client_log_filters")]
        public IList<NSXTALBClientLogFilterType> ClientLogFilters { get; set; }
        /// <summary>
        /// [DEPRECATED] Disable Analytics on this VirtualService. This will disable the collection of both metrics and logs. Please
        /// use following fields in AnalytcsProfile to control this behavior instead. disable_vs_analytics (for VirtualServices
        /// metrics), disable_server_analytics (for Pool metrics) and client_log_config (for logs). Field deprecated in 18.2.1.
        /// Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Placeholder for description of property full_client_logs of obj type AnalyticsPolicy field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "full_client_logs")]
        public NSXTALBFullClientLogsType FullClientLogs { get; set; }
        /// <summary>
        /// Configuration for learning logging determining whether it's enabled and where is the destination. Field introduced in
        /// 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "learning_log_policy")]
        public NSXTALBLearningLogPolicyType LearningLogPolicy { get; set; }
        /// <summary>
        /// Settings to turn on realtime metrics and set duration for realtime updates.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_realtime_update")]
        public NSXTALBMetricsRealTimeUpdateType MetricsRealtimeUpdate { get; set; }
        /// <summary>
        /// This setting limits the number of significant logs generated per second for this VS on each SE. Default is 10 logs per
        /// second. Set it to zero (0) to deactivate throttling. Field introduced in 17.1.3. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log_throttle")]
        public int? SignificantLogThrottle { get; set; }
        /// <summary>
        /// This setting limits the total number of UDF logs generated per second for this VS on each SE. UDF logs are generated due
        /// to the configured client log filters or the rules with logging enabled. Default is 10 logs per second. Set it to zero
        /// (0) to deactivate throttling. Field introduced in 17.1.3. Unit is PER_SECOND.
        /// </summary>
        [JsonProperty(PropertyName = "udf_log_throttle")]
        public int? UdfLogThrottle { get; set; }
    }
}
