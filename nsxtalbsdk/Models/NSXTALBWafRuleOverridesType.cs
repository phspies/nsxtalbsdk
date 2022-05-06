using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafRuleOverridesType
    {
        /// <summary>
        /// Override the enable flag for this rule. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Replace the exclude list for this rule. Field introduced in 20.1.6. Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// Override the waf mode for this rule. Enum options - WAF_MODE_DETECTION_ONLY, WAF_MODE_ENFORCEMENT. Field introduced in
        /// 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// The rule_id of the rule where attributes are overridden. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RuleId { get; set; }
    }
}
