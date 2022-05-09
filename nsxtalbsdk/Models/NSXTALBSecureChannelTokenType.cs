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
    public class NSXTALBSecureChannelTokenType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Expiry time for auth_token.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_time")]
        public double? ExpiryTime { get; set; }
        /// <summary>
        /// Whether this auth_token is used by some node(SE/controller). Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "in_use")]
        public bool? InUse { get; set; }
        /// <summary>
        /// Metadata associated with auth_token.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTALBSecureChannelMetadataType> Metadata { get; set; }
        /// <summary>
        /// Auth_token used for SE/controller authorization.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Deprecated  Uuid of SE or controller who is using this auth_token. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Auth_token used for SE/controller authorization.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
