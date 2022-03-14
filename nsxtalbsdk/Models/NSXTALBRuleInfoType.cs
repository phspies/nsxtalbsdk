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
    public class NSXTALBRuleInfoType 
    {
        /// <summary>
        /// URI hitted signature rule matches. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "matches")]
        public IList<NSXTALBMatchesType> Matches { get; set; }
        /// <summary>
        /// URI hitted signature rule group id. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rule_group_id")]
        public string? RuleGroupId { get; set; }
        /// <summary>
        /// URI hitted signature rule id. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public string? RuleId { get; set; }
    }
}
