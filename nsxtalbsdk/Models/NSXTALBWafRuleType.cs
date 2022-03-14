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
    public class NSXTALBWafRuleType 
    {
        /// <summary>
        /// Enable or disable WAF Rule Group. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// Exclude list for the WAF rule. The fields in the exclude list entry are logically and'ed to deduce the exclusion
        /// criteria. If there are multiple excludelist entries, it will be 'logical or' of them. Field introduced in 17.2.3.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// When set to 'true', this rule will not cause 'deny' or 'redirect' actions to run, even if WAF Policy is set to
        /// enforcement mode. The behavior would be as if this rule operated in detection mode regardless of WAF Policy setting.
        /// Field deprecated in 18.1.5. Field introduced in 18.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "force_detection")]
        public bool? ForceDetection { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// The rule field is sensitive and will not be displayed. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_sensitive")]
        public bool? IsSensitive { get; set; }
        /// <summary>
        /// WAF Rule mode. This can be detection or enforcement. If this is not set, the Policy mode is used. This only takes effect
        /// if the policy allows delegation. Enum options - WAF_MODE_DETECTION_ONLY, WAF_MODE_ENFORCEMENT. Field introduced in
        /// 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// User-friendly optional name for a rule. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The execution phase where this rule will be executed. Enum options - WAF_PHASE_CONNECTION, WAF_PHASE_REQUEST_HEADER,
        /// WAF_PHASE_REQUEST_BODY, WAF_PHASE_RESPONSE_HEADER, WAF_PHASE_RESPONSE_BODY, WAF_PHASE_LOGGING. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        public string? Phase { get; set; }
        /// <summary>
        /// Rule as per Modsec language. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "rule", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Rule { get; set; }
        /// <summary>
        /// Identifier (id) for a rule per Modsec language. All SecRule and SecAction directives require an id. It is extracted from
        /// the id action in a Modsec rule. Rules within a single WAF Policy are required to have unique rule_ids. Field introduced
        /// in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public string? RuleId { get; set; }
        /// <summary>
        /// Tags for WAF rule as per Modsec language. They are extracted from the tag action in a ModSec rule. Field introduced in
        /// 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
