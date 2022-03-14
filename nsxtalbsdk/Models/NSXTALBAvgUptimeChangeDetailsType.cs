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
    public class NSXTALBAvgUptimeChangeDetailsType 
    {
        public NSXTALBAvgUptimeChangeDetailsType()
        {
        }
        /// <summary>
        /// Placeholder for description of property current_value of obj type AvgUptimeChangeDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "current_value")]
        public double? CurrentValue { get; set; }
        /// <summary>
        /// metric_id of AvgUptimeChangeDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// metric_name of AvgUptimeChangeDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metric_name")]
        public string? MetricName { get; set; }
        /// <summary>
        /// resource_str of AvgUptimeChangeDetails.
        /// </summary>
        [JsonProperty(PropertyName = "resource_str")]
        public string? ResourceStr { get; set; }
        /// <summary>
        /// Placeholder for description of property threshold of obj type AvgUptimeChangeDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public double? Threshold { get; set; }
    }
}
