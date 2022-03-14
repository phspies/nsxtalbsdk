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
    public class NSXTALBAuthProfileType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// HTTP user authentication params.
        /// </summary>
        [JsonProperty(PropertyName = "http")]
        public NSXTALBAuthProfileHTTPClientParamsType Http { get; set; }
        /// <summary>
        /// JWTServerProfile to be used for authentication. It is a reference to an object of type JWTServerProfile. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_profile_ref")]
        public string? JwtProfileRef { get; set; }
        /// <summary>
        /// LDAP server and directory settings.
        /// </summary>
        [JsonProperty(PropertyName = "ldap")]
        public NSXTALBLdapAuthSettingsType Ldap { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.6. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Name of the Auth Profile.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// OAuth Profile - Common endpoint information. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oauth_profile")]
        public NSXTALBOAuthProfileType OauthProfile { get; set; }
        /// <summary>
        /// PingAccessAgent uuid. It is a reference to an object of type PingAccessAgent. Field introduced in 18.2.3. Allowed in
        /// Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "pa_agent_ref")]
        public string? PaAgentRef { get; set; }
        /// <summary>
        /// SAML settings. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "saml")]
        public NSXTALBSamlSettingsType Saml { get; set; }
        /// <summary>
        /// TACACS+ settings.
        /// </summary>
        [JsonProperty(PropertyName = "tacacs_plus")]
        public NSXTALBTacacsPlusAuthSettingsType TacacsPlus { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Type of the Auth Profile. Enum options - AUTH_PROFILE_LDAP, AUTH_PROFILE_TACACS_PLUS, AUTH_PROFILE_SAML,
        /// AUTH_PROFILE_PINGACCESS, AUTH_PROFILE_JWT, AUTH_PROFILE_OAUTH.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the Auth Profile.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
