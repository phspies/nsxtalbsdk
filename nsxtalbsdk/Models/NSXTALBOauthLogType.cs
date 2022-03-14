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
    public class NSXTALBOauthLogType 
    {
        public NSXTALBOauthLogType()
        {
        }
        /// <summary>
        /// Authentication policy rule match. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "authn_rule_match")]
        public NSXTALBAuthnRuleMatchType AuthnRuleMatch { get; set; }
        /// <summary>
        /// Authorization policy rule match. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "authz_rule_match")]
        public NSXTALBAuthzRuleMatchType AuthzRuleMatch { get; set; }
        /// <summary>
        /// OAuth SessionCookie expired. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_session_cookie_expired")]
        public bool? IsSessionCookieExpired { get; set; }
        /// <summary>
        /// Subrequest info related to fetching jwks keys from jwks uri endpoint. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwks_subrequest")]
        public NSXTALBOauthSubRequestLogType JwksSubrequest { get; set; }
        /// <summary>
        /// OAuth state. Enum options - OAUTH_STATE_CLIENT_IDP_HANDSHAKE_REDIRECT, OAUTH_STATE_CLIENT_IDP_HANDSHAKE_FAIL,
        /// OAUTH_STATE_TOKEN_EXCHANGE_REQUEST, OAUTH_STATE_TOKEN_EXCHANGE_RESPONSE, OAUTH_STATE_TOKEN_INTROSPECTION_REQUEST,
        /// OAUTH_STATE_TOKEN_INTROSPECTION_RESPONSE, OAUTH_STATE_REFRESH_TOKEN_REQUEST, OAUTH_STATE_REFRESH_TOKEN_RESPONSE,
        /// OAUTH_STATE_JWKS_URI_REQUEST, OAUTH_STATE_JWKS_URI_RESPONSE, OAUTH_STATE_USERINFO_REQUEST,
        /// OAUTH_STATE_USERINFO_RESPONSE. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oauth_state")]
        public string? OauthState { get; set; }
        /// <summary>
        /// OAuth request State to avoid CSRF atatcks. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// Subrequest info related to the code exchange flow. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "token_exchange_subrequest")]
        public NSXTALBOauthSubRequestLogType TokenExchangeSubrequest { get; set; }
        /// <summary>
        /// Subrequest info related to Token Introspection. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "token_introspection_subrequest")]
        public NSXTALBOauthSubRequestLogType TokenIntrospectionSubrequest { get; set; }
        /// <summary>
        /// Subrequest info related to refresh access Token flow. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "token_refresh_subrequest")]
        public NSXTALBOauthSubRequestLogType TokenRefreshSubrequest { get; set; }
        /// <summary>
        /// Subrequest info related to fetching userinfo from userinfo endpoint. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "userinfo_subrequest")]
        public NSXTALBOauthSubRequestLogType UserinfoSubrequest { get; set; }
    }
}
