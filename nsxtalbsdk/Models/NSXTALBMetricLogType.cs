using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricLogType
    {
        /// <summary>
        /// Placeholder for description of property end_timestamp of obj type MetricLog field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "end_timestamp")]
        public double? EndTimestamp { get; set; }
        /// <summary>
        /// metric_id of MetricLog.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricId { get; set; }
        /// <summary>
        /// Placeholder for description of property report_timestamp of obj type MetricLog field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "report_timestamp")]
        public double? ReportTimestamp { get; set; }
        /// <summary>
        /// Number of step.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public int? Step { get; set; }
        /// <summary>
        /// Placeholder for description of property time_series of obj type MetricLog field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "time_series")]
        public NSXTALBMetricsQueryResponseType TimeSeries { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type MetricLog field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
