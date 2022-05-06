using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAuthenticationPolicyType
    {
        /// <summary>
        /// Auth Profile to use for validating users. It is a reference to an object of type AuthProfile. Field deprecated in
        /// 18.2.3. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_ref")]
        public string? AuthProfileRef { get; set; }
        /// <summary>
        /// Add rules to apply auth profile to specific targets. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "authn_rules")]
        public IList<NSXTALBAuthenticationRuleType> AuthnRules { get; set; }
        /// <summary>
        /// HTTP cookie name for authenticated session. Field deprecated in 18.2.3. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        public string? CookieName { get; set; }
        /// <summary>
        /// Cookie timeout in minutes. Allowed values are 1-1440. Field deprecated in 18.2.3. Field introduced in 18.2.1. Unit is
        /// MIN.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_timeout")]
        public int? CookieTimeout { get; set; }
        /// <summary>
        /// Auth Profile to use for validating users. It is a reference to an object of type AuthProfile. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "default_auth_profile_ref")]
        public string? DefaultAuthProfileRef { get; set; }
        /// <summary>
        /// Globally unique entityID for this node. Entity ID on the IDP should match this. Field deprecated in 18.2.3. Field
        /// introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id")]
        public string? EntityId { get; set; }
        /// <summary>
        /// Key to generate the cookie. Field deprecated in 18.2.3. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// Single Signon URL to be programmed on the IDP. Field deprecated in 18.2.3. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "single_signon_url")]
        public string? SingleSignonUrl { get; set; }
        /// <summary>
        /// SAML SP metadata. Field deprecated in 18.2.3. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sp_metadata")]
        public string? SpMetadata { get; set; }
    }
}
