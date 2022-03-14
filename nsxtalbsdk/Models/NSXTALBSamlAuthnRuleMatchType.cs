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
    public class NSXTALBSamlAuthnRuleMatchType 
    {
        /// <summary>
        /// Name of the executed SAML Authentication rule Action. Enum options - SKIP_AUTHENTICATION, USE_DEFAULT_AUTHENTICATION.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_authn_matched_rule_action")]
        public string? SamlAuthnMatchedRuleAction { get; set; }
        /// <summary>
        /// Name of the matched SAML Authentication rule. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_authn_matched_rule_name")]
        public string? SamlAuthnMatchedRuleName { get; set; }
    }
}
