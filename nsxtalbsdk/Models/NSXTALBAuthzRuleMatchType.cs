using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAuthzRuleMatchType
    {
        /// <summary>
        /// Name of the executed Authorization rule Action. Enum options - ALLOW_ACCESS, CLOSE_CONNECTION, HTTP_LOCAL_RESPONSE.
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_action")]
        public string? RuleAction { get; set; }
        /// <summary>
        /// Name of the matched Authorization rule. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_name")]
        public string? RuleName { get; set; }
    }
}
