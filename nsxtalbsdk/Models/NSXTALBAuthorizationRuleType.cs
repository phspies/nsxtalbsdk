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
    public class NSXTALBAuthorizationRuleType 
    {
        public NSXTALBAuthorizationRuleType()
        {
        }
        /// <summary>
        /// Authorization action when rule is matched. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBAuthorizationActionType Action { get; set; }
        /// <summary>
        /// Enable or disable the rule. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// Index of the Authorization Policy rule. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Authorization match criteria for the rule. Field introduced in 18.2.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "match", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBAuthorizationMatchType Match { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
