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
    public class NSXTALBSecureChannelMappingType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Auth_token used for SE authorization. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "auth_token")]
        public string? AuthToken { get; set; }
        /// <summary>
        /// IP of SE.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// Whether this entry used for controller.
        /// </summary>
        [JsonProperty(PropertyName = "is_controller")]
        public bool? IsController { get; set; }
        /// <summary>
        /// Local ip on controller side reserved for SE.
        /// </summary>
        [JsonProperty(PropertyName = "local_ip")]
        public string? LocalIp { get; set; }
        /// <summary>
        /// Whether this entry is marked for delete (first step of deletion).
        /// </summary>
        [JsonProperty(PropertyName = "marked_for_delete")]
        public bool? MarkedForDelete { get; set; }
        /// <summary>
        /// Metadata associated with auth_token. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTALBSecureChannelMetadataType> Metadata { get; set; }
        /// <summary>
        /// Uuid of SE.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Public key of SE.
        /// </summary>
        [JsonProperty(PropertyName = "pub_key")]
        public string? PubKey { get; set; }
        /// <summary>
        /// Public key pem of SE.
        /// </summary>
        [JsonProperty(PropertyName = "pub_key_pem")]
        public string? PubKeyPem { get; set; }
        /// <summary>
        /// Authorization status of current secure channel. Enum options - SECURE_CHANNEL_NONE, SECURE_CHANNEL_CONNECTED,
        /// SECURE_CHANNEL_AUTH_SSH_SUCCESS, SECURE_CHANNEL_AUTH_SSH_FAILED, SECURE_CHANNEL_AUTH_TOKEN_SUCCESS,
        /// SECURE_CHANNEL_AUTH_TOKEN_FAILED, SECURE_CHANNEL_AUTH_ERRORS, SECURE_CHANNEL_AUTH_IGNORED.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Uuid of SE.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
