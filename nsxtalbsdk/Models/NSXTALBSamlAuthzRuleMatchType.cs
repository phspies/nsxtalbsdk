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
    public class NSXTALBSamlAuthzRuleMatchType 
    {
        public NSXTALBSamlAuthzRuleMatchType()
        {
        }
        /// <summary>
        /// Name of the executed SAML Authorization rule Action. Enum options - ALLOW_ACCESS, CLOSE_CONNECTION, HTTP_LOCAL_RESPONSE.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_authz_matched_rule_action")]
        public string? SamlAuthzMatchedRuleAction { get; set; }
        /// <summary>
        /// Name of the matched SAML Authorization rule. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_authz_matched_rule_name")]
        public string? SamlAuthzMatchedRuleName { get; set; }
    }
}
