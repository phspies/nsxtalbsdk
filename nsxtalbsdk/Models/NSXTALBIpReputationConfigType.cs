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
    public class NSXTALBIpReputationConfigType 
    {
        /// <summary>
        /// IP reputation db file object expiry duration in days. Allowed values are 1-7. Field introduced in 20.1.1. Unit is DAYS.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_file_object_expiry_duration")]
        public int? IpReputationFileObjectExpiryDuration { get; set; }
        /// <summary>
        /// IP reputation db sync interval in minutes. Allowed values are 2-1440. Field introduced in 20.1.1. Unit is MIN. Allowed
        /// in Basic(Allowed values- 60) edition, Essentials(Allowed values- 60) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_sync_interval")]
        public int? IpReputationSyncInterval { get; set; }
    }
}
