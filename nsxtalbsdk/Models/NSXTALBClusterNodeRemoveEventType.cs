using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBClusterNodeRemoveEventType
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
        /// Role of the node when it left the controller cluster. Enum options - CLUSTER_LEADER, CLUSTER_FOLLOWER.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string? Role { get; set; }
    }
}
