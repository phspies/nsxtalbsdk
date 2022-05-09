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
    public class NSXTALBJWTServerProfileType 
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
        /// JWT Auth configuration for profile_type CONTROLLER_INTERNAL_AUTH. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "controller_internal_auth")]
        public NSXTALBControllerInternalAuthType ControllerInternalAuth { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster.  If the field is set to true, then the object is replicated across the federation.  . Field
        /// introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
        /// <summary>
        /// Uniquely identifiable name of the Token Issuer, only allowed with profile_type CLIENT_AUTH. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
        /// <summary>
        /// JWKS key set used for validating the JWT, only allowed with profile_type CLIENT_AUTH. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwks_keys")]
        public string? JwksKeys { get; set; }
        /// <summary>
        /// Type of JWT Server profile which defines the usage type. Enum options - CLIENT_AUTH, CONTROLLER_INTERNAL_AUTH. Field
        /// introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_profile_type")]
        public string? JwtProfileType { get; set; }
        /// <summary>
        /// Name of the JWT Profile. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUID of the Tenant. It is a reference to an object of type Tenant. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the JWTProfile. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
