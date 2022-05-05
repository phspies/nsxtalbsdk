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
    public class NSXTALBWafRuleLogType 
    {
        /// <summary>
        /// Transaction data that matched the rule. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "matches")]
        public IList<NSXTALBWafRuleMatchDataType> Matches { get; set; }
        /// <summary>
        /// Rule's msg string per ModSec language. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "msg")]
        public string? Msg { get; set; }
        /// <summary>
        /// Phase in which transaction matched the Rule - for instance, Request Header Phase. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        public string? Phase { get; set; }
        /// <summary>
        /// Rule Group for the matching rule. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "rule_group")]
        public string? RuleGroup { get; set; }
        /// <summary>
        /// ID of the matching rule per ModSec language. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public long? RuleId { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "rule_name")]
        public string? RuleName { get; set; }
        /// <summary>
        /// Rule's tags per ModSec language. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
