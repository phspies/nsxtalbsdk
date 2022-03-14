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
    public class NSXTALBBotConfigIPReputationType 
    {
        /// <summary>
        /// Whether IP reputation-based Bot detection is enabled. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The UUID of the IP reputation DB to use. It is a reference to an object of type IPReputationDB. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_db_ref")]
        public string? IpReputationDbRef { get; set; }
        /// <summary>
        /// The system-provided mapping from IP reputation types to Bot types. It is a reference to an object of type
        /// BotIPReputationTypeMapping. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "system_ip_reputation_mapping_ref")]
        public string? SystemIpReputationMappingRef { get; set; }
    }
}
