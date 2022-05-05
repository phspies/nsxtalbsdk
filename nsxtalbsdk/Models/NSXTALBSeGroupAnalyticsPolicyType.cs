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
    public class NSXTALBSeGroupAnalyticsPolicyType 
    {
        /// <summary>
        /// Thresholds for various events generated by metrics system. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_event_thresholds")]
        public IList<NSXTALBMetricsEventThresholdType> MetricsEventThresholds { get; set; }
    }
}
