using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBClusterLeaderFailoverEventType
    {
        /// <summary>
        /// Details of the new controller cluster leader node.
        /// </summary>
        [JsonProperty(PropertyName = "leader_node")]
        public NSXTALBClusterNodeType LeaderNode { get; set; }
        /// <summary>
        /// Details of the previous controller cluster leader.
        /// </summary>
        [JsonProperty(PropertyName = "previous_leader_node")]
        public NSXTALBClusterNodeType PreviousLeaderNode { get; set; }
    }
}
