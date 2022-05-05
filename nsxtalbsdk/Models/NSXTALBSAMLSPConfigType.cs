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
    public class NSXTALBSAMLSPConfigType 
    {
        /// <summary>
        /// HTTP cookie name for authenticated session. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        public string? CookieName { get; set; }
        /// <summary>
        /// Cookie timeout in minutes. Allowed values are 1-1440. Field introduced in 18.2.3. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_timeout")]
        public int? CookieTimeout { get; set; }
        /// <summary>
        /// Globally unique SAML entityID for this node. The SAML application entity ID on the IDP should match this. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EntityId { get; set; }
        /// <summary>
        /// Key to generate the cookie. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// SP will use this SSL certificate to sign requests going to the IdP and decrypt the assertions coming from IdP. It is a
        /// reference to an object of type SSLKeyAndCertificate. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "signing_ssl_key_and_certificate_ref")]
        public string? SigningSslKeyAndCertificateRef { get; set; }
        /// <summary>
        /// SAML Single Signon URL to be programmed on the IDP. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "single_signon_url")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SingleSignonUrl { get; set; }
        /// <summary>
        /// SAML SP metadata for this application. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sp_metadata")]
        public string? SpMetadata { get; set; }
        /// <summary>
        /// By enabling this field IdP can control how long the SP session can exist through the SessionNotOnOrAfter field in the
        /// AuthNStatement of SAML Response. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "use_idp_session_timeout")]
        public bool? UseIdpSessionTimeout { get; set; }
    }
}
