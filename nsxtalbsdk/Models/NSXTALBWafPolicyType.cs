using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafPolicyType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Allow Rules to overwrite the policy mode. This must be set if the policy mode is set to enforcement. Field introduced in
        /// 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "allow_mode_delegation")]
        public bool? AllowModeDelegation { get; set; }
        /// <summary>
        /// A set of rules which describe conditions under which the request will bypass the WAF. This will be processed in the
        /// request header phase before any other WAF related code. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "allowlist")]
        public NSXTALBWafPolicyAllowlistType Allowlist { get; set; }
        /// <summary>
        /// Application Specific Signatures. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "application_signatures")]
        public NSXTALBWafApplicationSignaturesType ApplicationSignatures { get; set; }
        /// <summary>
        /// Enable the functionality to bypass WAF for static file extensions. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "bypass_static_extensions")]
        public bool? BypassStaticExtensions { get; set; }
        /// <summary>
        /// Configure thresholds for confidence labels. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "confidence_override")]
        public NSXTALBAppLearningConfidenceOverrideType ConfidenceOverride { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Creator name. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// This entry is deprecated. If you want to change the property of a CRS group or rule (enabled, mode, exclusions), please
        /// use the crs_overrides field instead. Field deprecated in 20.1.6. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "crs_groups")]
        public IList<NSXTALBWafRuleGroupType> CrsGroups { get; set; }
        /// <summary>
        /// Override attributes for CRS rules. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "crs_overrides")]
        public IList<NSXTALBWafRuleGroupOverridesType> CrsOverrides { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Enable Application Learning for this WAF policy. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_app_learning")]
        public bool? EnableAppLearning { get; set; }
        /// <summary>
        /// Enable Application Learning based rule updates on the WAF Profile. Rules will be programmed in dedicated WAF learning
        /// group. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_rule_updates")]
        public bool? EnableAutoRuleUpdates { get; set; }
        /// <summary>
        /// Enable dynamic regex generation for positive security model rules. This is an experimental feature and shouldn't be used
        /// in production. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_regex_learning")]
        public bool? EnableRegexLearning { get; set; }
        /// <summary>
        /// WAF Policy failure mode. This can be 'Open' or 'Closed'. Enum options - WAF_FAILURE_MODE_OPEN, WAF_FAILURE_MODE_CLOSED.
        /// Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "failure_mode")]
        public string? FailureMode { get; set; }
        /// <summary>
        /// Geo Location Mapping Database used by this WafPolicy. It is a reference to an object of type GeoDB. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "geo_db_ref")]
        public string? GeoDbRef { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Configure parameters for WAF learning. Field deprecated in 18.2.3. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "learning")]
        public NSXTALBWafLearningType Learning { get; set; }
        /// <summary>
        /// Parameters for tuning Application learning. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "learning_params")]
        public NSXTALBAppLearningParamsType LearningParams { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Minimum confidence label required for auto rule updates. Enum options - CONFIDENCE_VERY_HIGH, CONFIDENCE_HIGH,
        /// CONFIDENCE_PROBABLE, CONFIDENCE_LOW, CONFIDENCE_NONE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_confidence")]
        public string? MinConfidence { get; set; }
        /// <summary>
        /// WAF Policy mode. This can be detection or enforcement. It can be overwritten by rules if allow_mode_delegation is set.
        /// Enum options - WAF_MODE_DETECTION_ONLY, WAF_MODE_ENFORCEMENT. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mode { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// WAF Ruleset paranoia  mode. This is used to select Rules based on the paranoia-level tag. Enum options -
        /// WAF_PARANOIA_LEVEL_LOW, WAF_PARANOIA_LEVEL_MEDIUM, WAF_PARANOIA_LEVEL_HIGH, WAF_PARANOIA_LEVEL_EXTREME. Field introduced
        /// in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "paranoia_level")]
        public string? ParanoiaLevel { get; set; }
        /// <summary>
        /// The Positive Security Model. This is used to describe how the request or parts of the request should look like. It is
        /// executed in the Request Body Phase of Avi WAF. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "positive_security_model")]
        public NSXTALBWafPositiveSecurityModelType PositiveSecurityModel { get; set; }
        /// <summary>
        /// WAF Rules are categorized in to groups based on their characterization. These groups are created by the user and will be
        /// enforced after the CRS groups. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "post_crs_groups")]
        public IList<NSXTALBWafRuleGroupType> PostCrsGroups { get; set; }
        /// <summary>
        /// WAF Rules are categorized in to groups based on their characterization. These groups are created by the user and will be
        /// enforced before the CRS groups. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "pre_crs_groups")]
        public IList<NSXTALBWafRuleGroupType> PreCrsGroups { get; set; }
        /// <summary>
        /// A resolved version of waf_crs_ref with waf_crs_overrides applied. Field deprecated in 21.1.3. Field introduced in
        /// 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "resolved_crs_groups")]
        public IList<NSXTALBWafRuleGroupType> ResolvedCrsGroups { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// WAF core ruleset used for the CRS part of this Policy. It is a reference to an object of type WafCRS. Field introduced
        /// in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "waf_crs_ref")]
        public string? WafCrsRef { get; set; }
        /// <summary>
        /// WAF Profile for WAF policy. It is a reference to an object of type WafProfile. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "waf_profile_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string WafProfileRef { get; set; }
        /// <summary>
        /// A set of rules which describe conditions under which the request will bypass the WAF. This will be executed in the
        /// request header phase before any other WAF related code. Field deprecated in 20.1.3. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "whitelist")]
        public NSXTALBWafPolicyWhitelistType Whitelist { get; set; }
    }
}
