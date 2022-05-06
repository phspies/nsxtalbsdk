using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbReplicationStatsType
    {
        /// <summary>
        /// Last config version acknowledged. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledged_version")]
        public long? AcknowledgedVersion { get; set; }
        /// <summary>
        /// Number of pending objects. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pending_object_count")]
        public long? PendingObjectCount { get; set; }
        /// <summary>
        /// Last config version received. On leader, this represents the version received from federated datastore. Field introduced
        /// in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "received_version")]
        public long? ReceivedVersion { get; set; }
    }
}
