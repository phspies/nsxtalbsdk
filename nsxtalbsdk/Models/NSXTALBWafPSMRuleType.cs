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
    public class NSXTALBWafPSMRuleType 
    {
        /// <summary>
        /// Free-text comment about this rule. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable or disable this rule. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Rule index, this is used to determine the order of the rules. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// The field match_value_pattern regular expression is case sensitive. Enum options - SENSITIVE, INSENSITIVE. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        public string? MatchCase { get; set; }
        /// <summary>
        /// The match elements, for example ARGS id or ARGS|!ARGS password. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_elements")]
        public IList<NSXTALBWafPSMMatchElementType> MatchElements { get; set; }
        /// <summary>
        /// The maximum allowed length of the match_value. If this is not set, the length will not be checked. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_value_max_length")]
        public int? MatchValueMaxLength { get; set; }
        /// <summary>
        /// A regular expression which describes the expected value. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_value_pattern")]
        public string? MatchValuePattern { get; set; }
        /// <summary>
        /// If match_value_string_group_uuid and match_value_string_group_key are set, the referenced regular expression is used as
        /// match_value_pattern. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_value_string_group_key")]
        public string? MatchValueStringGroupKey { get; set; }
        /// <summary>
        /// The UUID of a string group containing key used in match_value_string_group_key. It is a reference to an object of type
        /// StringGroup. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_value_string_group_ref")]
        public string? MatchValueStringGroupRef { get; set; }
        /// <summary>
        /// WAF Rule mode. This can be detection or enforcement. If this is not set, the Policy mode is used. This only takes effect
        /// if the policy allows delegation. Enum options - WAF_MODE_DETECTION_ONLY, WAF_MODE_ENFORCEMENT. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// WAF Ruleset paranoia mode. This is used to select Rules based on the paranoia-level. Enum options -
        /// WAF_PARANOIA_LEVEL_LOW, WAF_PARANOIA_LEVEL_MEDIUM, WAF_PARANOIA_LEVEL_HIGH, WAF_PARANOIA_LEVEL_EXTREME. Field introduced
        /// in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "paranoia_level")]
        public string? ParanoiaLevel { get; set; }
        /// <summary>
        /// Id field which is used for log and metric generation. This id must be unique for all rules in this group. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RuleId { get; set; }
    }
}
