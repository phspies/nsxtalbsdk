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
    public class NSXTALBOAuthProfileType 
    {
        /// <summary>
        /// URL of authorization server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "authorization_endpoint")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AuthorizationEndpoint { get; set; }
        /// <summary>
        /// URL of token introspection server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "introspection_endpoint")]
        public string? IntrospectionEndpoint { get; set; }
        /// <summary>
        /// Uniquely identifiable name of the Token Issuer. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
        /// <summary>
        /// Lifetime of the cached JWKS keys. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwks_timeout")]
        public int? JwksTimeout { get; set; }
        /// <summary>
        /// JWKS URL of the endpoint that hosts the public keys that can be used to verify any JWT issued by the authorization
        /// server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwks_uri")]
        public string? JwksUri { get; set; }
        /// <summary>
        /// Buffering size for the responses from the OAUTH enpoints. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oauth_resp_buffer_sz")]
        public int? OauthRespBufferSz { get; set; }
        /// <summary>
        /// Pool object to interface with Authorization Server endpoints. It is a reference to an object of type Pool. Field
        /// introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// URL of token exchange server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "token_endpoint")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TokenEndpoint { get; set; }
        /// <summary>
        /// URL of the Userinfo Endpoint. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }
    }
}
