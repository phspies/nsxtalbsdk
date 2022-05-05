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
    public class NSXTALBWafRuleGroupOverridesType 
    {
        /// <summary>
        /// Override the enable flag for this group. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Replace the exclude list for this group. Field introduced in 20.1.6. Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// Override the waf mode for this group.. Enum options - WAF_MODE_DETECTION_ONLY, WAF_MODE_ENFORCEMENT. Field introduced in
        /// 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// The name of the group where attributes or rules are overridden. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Rule specific overrides. Field introduced in 20.1.6. Maximum of 1024 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "rule_overrides")]
        public IList<NSXTALBWafRuleOverridesType> RuleOverrides { get; set; }
    }
}
