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
    public class NSXTALBAuthenticationRuleType 
    {
        /// <summary>
        /// Enable or disable authentication for matched targets. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public NSXTALBAuthenticationActionType Action { get; set; }
        /// <summary>
        /// Enable or disable the rule. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// Index of the rule. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Add match criteria to the rule. Field introduced in 18.2.5. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBAuthenticationMatchType Match { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
