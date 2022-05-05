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
    public class NSXTALBWAFLimitsType 
    {
        /// <summary>
        /// Number of WAF allowed Content Types. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_allowed_content_types")]
        public int? NumAllowedContentTypes { get; set; }
        /// <summary>
        /// Number of allowed request content type character sets in WAF. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_allowed_request_content_type_charsets")]
        public int? NumAllowedRequestContentTypeCharsets { get; set; }
        /// <summary>
        /// Number of rules used in WAF allowlist policy. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_allowlist_policy_rules")]
        public int? NumAllowlistPolicyRules { get; set; }
        /// <summary>
        /// Number of applications for which we use rules from sig provider. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_applications")]
        public int? NumApplications { get; set; }
        /// <summary>
        /// Number of datafiles used in WAF. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_data_files")]
        public int? NumDataFiles { get; set; }
        /// <summary>
        /// Number of pre, post CRS groups. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_pre_post_crs_groups")]
        public int? NumPrePostCrsGroups { get; set; }
        /// <summary>
        /// Number of total PSM groups in WAF. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_psm_groups")]
        public int? NumPsmGroups { get; set; }
        /// <summary>
        /// Number of match elements used in WAF PSM. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_psm_match_elements")]
        public int? NumPsmMatchElements { get; set; }
        /// <summary>
        /// Number of match rules per location. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_psm_match_rules_per_loc")]
        public int? NumPsmMatchRulesPerLoc { get; set; }
        /// <summary>
        /// Number of locations used in WAF PSM. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_psm_total_locations")]
        public int? NumPsmTotalLocations { get; set; }
        /// <summary>
        /// Number of restricted extensions in WAF. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_restricted_extensions")]
        public int? NumRestrictedExtensions { get; set; }
        /// <summary>
        /// Number of restricted HTTP headers in WAF. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_restricted_headers")]
        public int? NumRestrictedHeaders { get; set; }
        /// <summary>
        /// Number of tags for waf rule . Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_rule_tags")]
        public int? NumRuleTags { get; set; }
        /// <summary>
        /// Number of rules as per modsec language. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_rules_per_rulegroup")]
        public int? NumRulesPerRulegroup { get; set; }
        /// <summary>
        /// Number of restricted static extensions in WAF. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_static_extensions")]
        public int? NumStaticExtensions { get; set; }
    }
}
