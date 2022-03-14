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
    public class NSXTALBPoolAnalyticsPolicyType 
    {
        public NSXTALBPoolAnalyticsPolicyType()
        {
        }
        /// <summary>
        /// Enable real time metrics for server and pool metrics eg. l4_server.xxx, l7_server.xxx. Field introduced in 18.1.5,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_realtime_metrics")]
        public bool? EnableRealtimeMetrics { get; set; }
    }
}
