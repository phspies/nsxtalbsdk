using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafAllowlistLogType
    {
        /// <summary>
        /// Actions generated by this rule. Enum options - WAF_POLICY_ALLOWLIST_ACTION_BYPASS,
        /// WAF_POLICY_ALLOWLIST_ACTION_DETECTION_MODE, WAF_POLICY_ALLOWLIST_ACTION_CONTINUE. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; set; }
        /// <summary>
        /// Name of the matched rule. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_name")]
        public string? RuleName { get; set; }
    }
}
