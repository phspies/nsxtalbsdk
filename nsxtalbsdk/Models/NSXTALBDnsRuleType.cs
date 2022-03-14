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
    public class NSXTALBDnsRuleType 
    {
        /// <summary>
        /// Action to be performed upon successful matching. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public NSXTALBDnsRuleActionType Action { get; set; }
        /// <summary>
        /// Enable or disable the rule. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Index of the rule. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Log DNS query upon rule match. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public bool? Log { get; set; }
        /// <summary>
        /// Add match criteria to the rule. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBDnsRuleMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
