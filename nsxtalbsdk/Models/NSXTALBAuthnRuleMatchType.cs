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
    public class NSXTALBAuthnRuleMatchType 
    {
        public NSXTALBAuthnRuleMatchType()
        {
        }
        /// <summary>
        /// Name of the executed Authentication rule Action. Enum options - SKIP_AUTHENTICATION, USE_DEFAULT_AUTHENTICATION. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_action")]
        public string? RuleAction { get; set; }
        /// <summary>
        /// Name of the matched Authentication rule. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_name")]
        public string? RuleName { get; set; }
    }
}
