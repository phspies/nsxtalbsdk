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
    public class NSXTALBJWTValidationVsConfigType 
    {
        /// <summary>
        /// Uniquely identifies a resource server. This is used to validate against the aud claim. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "audience", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Audience { get; set; }
        /// <summary>
        /// Defines where to look for JWT in the request. Enum options - JWT_LOCATION_AUTHORIZATION_HEADER,
        /// JWT_LOCATION_QUERY_PARAM. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_location", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string JwtLocation { get; set; }
        /// <summary>
        /// Name by which the JWT can be identified if the token is sent as a query param in the request url. Field introduced in
        /// 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_name")]
        public string? JwtName { get; set; }
    }
}
