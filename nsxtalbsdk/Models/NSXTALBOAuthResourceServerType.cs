using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOAuthResourceServerType
    {
        /// <summary>
        /// Access token type. Enum options - ACCESS_TOKEN_TYPE_JWT, ACCESS_TOKEN_TYPE_OPAQUE. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "access_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AccessType { get; set; }
        /// <summary>
        /// Validation parameters to be used when access token type is JWT. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_params")]
        public NSXTALBJWTValidationParamsType JwtParams { get; set; }
        /// <summary>
        /// Validation parameters to be used when access token type is opaque. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "opaque_token_params")]
        public NSXTALBOpaqueTokenValidationParamsType OpaqueTokenParams { get; set; }
    }
}
