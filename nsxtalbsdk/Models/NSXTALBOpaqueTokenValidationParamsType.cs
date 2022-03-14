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
    public class NSXTALBOpaqueTokenValidationParamsType 
    {
        /// <summary>
        /// Resource server specific identifier used to validate against introspection endpoint when access token is opaque. Field
        /// introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServerId { get; set; }
        /// <summary>
        /// Resource server specific password/secret. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_secret", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServerSecret { get; set; }
    }
}
