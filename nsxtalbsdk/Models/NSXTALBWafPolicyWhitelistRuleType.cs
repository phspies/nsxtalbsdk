using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafPolicyWhitelistRuleType
    {
        /// <summary>
        /// Actions to be performed upon successful matching. Enum options - WAF_POLICY_WHITELIST_ACTION_ALLOW,
        /// WAF_POLICY_WHITELIST_ACTION_DETECTION_MODE, WAF_POLICY_WHITELIST_ACTION_CONTINUE. Field deprecated in 20.1.3. Field
        /// introduced in 18.2.3. Minimum of 1 items required. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; set; }
        /// <summary>
        /// Description of this rule. Field deprecated in 20.1.3. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable or disable the rule. Field deprecated in 20.1.3. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Rules are executed in order of this index field. Field deprecated in 20.1.3. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Match criteria describing requests to which this rule should be applied. Field deprecated in 20.1.3. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBMatchTargetType Match { get; set; }
        /// <summary>
        /// A name describing the rule in a short form. Field deprecated in 20.1.3. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Percentage of traffic that is sampled. Allowed values are 0-100. Field deprecated in 20.1.3. Field introduced in 20.1.1.
        /// Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_percent")]
        public int? SamplingPercent { get; set; }
    }
}
