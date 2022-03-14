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
    public class NSXTALBSamlLogType 
    {
        /// <summary>
        /// Set to True if SAML Authentication is used. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "is_saml_authentication_used")]
        public bool? IsSamlAuthenticationUsed { get; set; }
        /// <summary>
        /// SAML Attribute list. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_attribute_lists")]
        public IList<NSXTALBSamlAttributeType> SamlAttributeLists { get; set; }
        /// <summary>
        /// Saml Authentication Status. Enum options - SAML_AUTH_STATUS_UNAVAILABLE, SAML_AUTH_STATUS_UNAUTH_GET_REQUEST,
        /// SAML_AUTH_STATUS_UNAUTH_REQ_UNSUPPORTED_METHOD, SAML_AUTH_STATUS_AUTH_REQUEST_GENERATED,
        /// SAML_AUTH_STATUS_AUTH_RESPONSE_RECEIVED, SAML_AUTH_STATUS_AUTHENTICATED_REQUEST, SAML_AUTH_STATUS_AUTHORIZATION_FAILED.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_auth_status")]
        public string? SamlAuthStatus { get; set; }
        /// <summary>
        /// SAML Authentication rule match. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_authn_rule_match")]
        public NSXTALBSamlAuthnRuleMatchType SamlAuthnRuleMatch { get; set; }
        /// <summary>
        /// SAML Authorization rule match. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_authz_rule_match")]
        public NSXTALBSamlAuthzRuleMatchType SamlAuthzRuleMatch { get; set; }
        /// <summary>
        /// Is set when SAML session cookie is expired. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "saml_session_cookie_expired")]
        public bool? SamlSessionCookieExpired { get; set; }
        /// <summary>
        /// SAML userid. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "userid")]
        public string? Userid { get; set; }
    }
}
