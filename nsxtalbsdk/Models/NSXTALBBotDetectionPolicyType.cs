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
    public class NSXTALBBotDetectionPolicyType 
    {
        public NSXTALBBotDetectionPolicyType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Allow the user to skip BotManagement for selected requests. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow_list")]
        public NSXTALBBotAllowListType AllowList { get; set; }
        /// <summary>
        /// Human-readable description of this Bot Detection Policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The IP location configuration used in this policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_location_detector", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBBotConfigIPLocationType IpLocationDetector { get; set; }
        /// <summary>
        /// The IP reputation configuration used in this policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_detector", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBBotConfigIPReputationType IpReputationDetector { get; set; }
        /// <summary>
        /// The name of this Bot Detection Policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// System-defined rules for classification. It is a reference to an object of type BotMapping. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "system_bot_mapping_ref")]
        public string? SystemBotMappingRef { get; set; }
        /// <summary>
        /// The installation provides an updated ruleset for consolidating the results of different decider phases. It is a
        /// reference to an object of type BotConfigConsolidator. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "system_consolidator_ref")]
        public string? SystemConsolidatorRef { get; set; }
        /// <summary>
        /// The unique identifier of the tenant to which this policy belongs. It is a reference to an object of type Tenant. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// The User-Agent configuration used in this policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user_agent_detector", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBBotConfigUserAgentType UserAgentDetector { get; set; }
        /// <summary>
        /// User-defined rules for classification. These are applied before the system classification rules. If a rule matches,
        /// processing terminates and the system-defined rules will not run. It is a reference to an object of type BotMapping.
        /// Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user_bot_mapping_ref")]
        public string? UserBotMappingRef { get; set; }
        /// <summary>
        /// The user-provided ruleset for consolidating the results of different decider phases. This runs before the system
        /// consolidator. If it successfully sets a consolidation, the system consolidator will not change it. It is a reference to
        /// an object of type BotConfigConsolidator. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user_consolidator_ref")]
        public string? UserConsolidatorRef { get; set; }
        /// <summary>
        /// A unique identifier to this Bot Detection Policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
