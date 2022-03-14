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
    public class NSXTALBWafApplicationSignaturesType 
    {
        /// <summary>
        /// The external provide for the rules. It is a reference to an object of type WafApplicationSignatureProvider. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "provider_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ProviderRef { get; set; }
        /// <summary>
        /// A resolved version of the active application specific rules together with the overrides. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "resolved_rules")]
        public IList<NSXTALBWafRuleType> ResolvedRules { get; set; }
        /// <summary>
        /// Override attributes of application signature rules. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "rule_overrides")]
        public IList<NSXTALBWafRuleOverridesType> RuleOverrides { get; set; }
        /// <summary>
        /// This entry is deprecated. If you want to deactivate a certain rule, please use the rule_overrides field instead. Field
        /// deprecated in 20.1.6. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafRuleType> Rules { get; set; }
        /// <summary>
        /// The version in use of the provided ruleset. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ruleset_version")]
        public string? RulesetVersion { get; set; }
        /// <summary>
        /// List of applications for which we use the rules from the WafApplicationSignatureProvider. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "selected_applications")]
        public IList<string> SelectedApplications { get; set; }
    }
}
