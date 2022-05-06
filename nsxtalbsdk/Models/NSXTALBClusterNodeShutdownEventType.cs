using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBClusterNodeShutdownEventType
    {
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
        /// <summary>
        /// Reason for controller node shutdown.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
    }
}
