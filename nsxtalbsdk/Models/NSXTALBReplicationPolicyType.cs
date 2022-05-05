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
    public class NSXTALBReplicationPolicyType 
    {
        /// <summary>
        /// Leader's checkpoint. Follower attempt to replicate configuration till this checkpoint. It is a reference to an object of
        /// type FederationCheckpoint. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "checkpoint_ref")]
        public string? CheckpointRef { get; set; }
        /// <summary>
        /// Replication mode. Enum options - REPLICATION_MODE_CONTINUOUS, REPLICATION_MODE_MANUAL, REPLICATION_MODE_ADAPTIVE. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "replication_mode")]
        public string? ReplicationMode { get; set; }
    }
}
