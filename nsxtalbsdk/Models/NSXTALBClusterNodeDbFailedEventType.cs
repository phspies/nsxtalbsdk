using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBClusterNodeDbFailedEventType
    {
        /// <summary>
        /// Number of failures.
        /// </summary>
        [JsonProperty(PropertyName = "failure_count")]
        public int? FailureCount { get; set; }
        /// <summary>
        /// IP address of the controller VM.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Name of controller node.
        /// </summary>
        [JsonProperty(PropertyName = "node_name")]
        public string? NodeName { get; set; }
    }
}
