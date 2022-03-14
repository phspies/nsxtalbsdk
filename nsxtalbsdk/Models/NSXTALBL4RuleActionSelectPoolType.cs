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
    public class NSXTALBL4RuleActionSelectPoolType 
    {
        /// <summary>
        /// Indicates action to take on rule match. Enum options - L4_RULE_ACTION_SELECT_POOL, L4_RULE_ACTION_SELECT_POOLGROUP.
        /// Field introduced in 17.2.7. Allowed in Basic(Allowed values- L4_RULE_ACTION_SELECT_POOL) edition, Essentials(Allowed
        /// values- L4_RULE_ACTION_SELECT_POOL) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "action_type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ActionType { get; set; }
        /// <summary>
        /// ID of the pool group to serve the request. It is a reference to an object of type PoolGroup. Field introduced in 17.2.7.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_ref")]
        public string? PoolGroupRef { get; set; }
        /// <summary>
        /// ID of the pool of servers to serve the request. It is a reference to an object of type Pool. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
    }
}
