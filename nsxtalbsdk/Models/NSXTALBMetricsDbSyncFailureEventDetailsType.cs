using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricsDbSyncFailureEventDetailsType
    {
        /// <summary>
        /// Name of the node responsible for this event.
        /// </summary>
        [JsonProperty(PropertyName = "node_name")]
        public string? NodeName { get; set; }
        /// <summary>
        /// Name of the process responsible for this event.
        /// </summary>
        [JsonProperty(PropertyName = "process_name")]
        public string? ProcessName { get; set; }
        /// <summary>
        /// Timestamp at which this event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
    }
}
