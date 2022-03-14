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
    public class NSXTALBSamlServiceProviderNodeType 
    {
        /// <summary>
        /// Globally unique entityID for this node. Entity ID on the IDP should match this. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id")]
        public string? EntityId { get; set; }
        /// <summary>
        /// Refers to the Cluster name identifier (Virtual IP or FQDN). Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Service Provider signing certificate for metadata. Field deprecated in 18.2.1. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "signing_cert")]
        public string? SigningCert { get; set; }
        /// <summary>
        /// Service Provider signing key for metadata. Field deprecated in 18.2.1. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "signing_key")]
        public string? SigningKey { get; set; }
        /// <summary>
        /// Service Engines will use this SSL certificate to sign assertions going to the IdP. It is a reference to an object of
        /// type SSLKeyAndCertificate. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "signing_ssl_key_and_certificate_ref")]
        public string? SigningSslKeyAndCertificateRef { get; set; }
        /// <summary>
        /// Single Signon URL to be programmed on the IDP. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "single_signon_url")]
        public string? SingleSignonUrl { get; set; }
    }
}
