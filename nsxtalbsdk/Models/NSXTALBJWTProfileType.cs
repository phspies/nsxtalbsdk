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
    public class NSXTALBJWTProfileType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster.  If the field is set to true, then the object is replicated across the federation.  . Field
        /// introduced in 20.1.5. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// JWK keys used for signing/validating the JWT. Field introduced in 20.1.5. Minimum of 1 items required. Maximum of 1
        /// items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "jwks_keys")]
        public IList<NSXTALBJWSKeyType> JwksKeys { get; set; }
        /// <summary>
        /// JWT auth type for JWT validation. Enum options - JWT_TYPE_JWS. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_auth_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string JwtAuthType { get; set; }
        /// <summary>
        /// A user friendly name for this jwt profile. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUID of the Tenant. It is a reference to an object of type Tenant. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the jwt profile. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
