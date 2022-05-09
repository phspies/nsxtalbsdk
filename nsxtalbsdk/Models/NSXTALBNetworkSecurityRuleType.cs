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
    public class NSXTALBNetworkSecurityRuleType 
    {
        /// <summary>
        /// Enum options - NETWORK_SECURITY_POLICY_ACTION_TYPE_ALLOW, NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY,
        /// NETWORK_SECURITY_POLICY_ACTION_TYPE_RATE_LIMIT. Allowed in Basic(Allowed values-
        /// NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY) edition, Essentials(Allowed values- NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Action { get; set; }
        /// <summary>
        /// Time in minutes after which rule will be deleted. Allowed values are 1-4294967295. Special values are 0- blocked for
        /// ever. Unit is MIN. Allowed in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Placeholder for description of property enable of obj type NetworkSecurityRule field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public bool? Log { get; set; }
        /// <summary>
        /// Placeholder for description of property match of obj type NetworkSecurityRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBNetworkSecurityMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property rl_param of obj type NetworkSecurityRule field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rl_param")]
        public NSXTALBNetworkSecurityPolicyActionRLParamType RlParam { get; set; }
    }
}
