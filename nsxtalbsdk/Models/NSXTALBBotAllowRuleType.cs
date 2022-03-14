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
    public class NSXTALBBotAllowRuleType 
    {
        public NSXTALBBotAllowRuleType()
        {
        }
        /// <summary>
        /// The action to take. Enum options - BOT_ACTION_BYPASS, BOT_ACTION_CONTINUE. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Action { get; set; }
        /// <summary>
        /// The condition to match. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "condition", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBMatchTargetType Condition { get; set; }
        /// <summary>
        /// Rules are processed in order of this index field. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// A name describing the rule in a short form. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
