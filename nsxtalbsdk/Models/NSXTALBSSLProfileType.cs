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
    public class NSXTALBSSLProfileType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Ciphers suites represented as defined by https //www.openssl.org/docs/apps/ciphers.html.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_ciphers")]
        public string? AcceptedCiphers { get; set; }
        /// <summary>
        /// Set of versions accepted by the server. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "accepted_versions")]
        public IList<NSXTALBSSLVersionType> AcceptedVersions { get; set; }
        /// <summary>
        /// Enum options - TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,
        /// TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,
        /// TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,
        /// TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_AES_128_CBC_SHA256,
        /// TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
        /// TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA,
        /// TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256,
        /// TLS_AES_128_GCM_SHA256. Allowed in Basic(Allowed values-
        /// TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_RSA_WITH_AES_128_GCM_SHA256,TLS_RSA_WITH_AES_256_GCM_SHA384,TLS_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_AES_128_CBC_SHA,TLS_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_3DES_EDE_CBC_SHA)
        /// edition, Essentials(Allowed values-
        /// TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_RSA_WITH_AES_128_GCM_SHA256,TLS_RSA_WITH_AES_256_GCM_SHA384,TLS_RSA_WITH_AES_128_CBC_SHA256,TLS_RSA_WITH_AES_256_CBC_SHA256,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_AES_128_CBC_SHA,TLS_RSA_WITH_AES_256_CBC_SHA,TLS_RSA_WITH_3DES_EDE_CBC_SHA)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_enums")]
        public IList<string> CipherEnums { get; set; }
        /// <summary>
        /// TLS 1.3 Ciphers suites represented as defined by U(https //www.openssl.org/docs/manmaster/man1/ciphers.html). Field
        /// introduced in 18.2.6. Allowed in Basic edition, Essentials edition, Enterprise edition. Special default for Basic
        /// edition is TLS_AES_256_GCM_SHA384-TLS_AES_128_GCM_SHA256, Essentials edition is
        /// TLS_AES_256_GCM_SHA384-TLS_AES_128_GCM_SHA256, Enterprise is
        /// TLS_AES_256_GCM_SHA384-TLS_CHACHA20_POLY1305_SHA256-TLS_AES_128_GCM_SHA256.
        /// </summary>
        [JsonProperty(PropertyName = "ciphersuites")]
        public string? Ciphersuites { get; set; }
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
        /// DH Parameters used in SSL. At this time, it is not configurable and is set to 2048 bits.
        /// </summary>
        [JsonProperty(PropertyName = "dhparam")]
        public string? Dhparam { get; set; }
        /// <summary>
        /// Elliptic Curve Cryptography NamedCurves (TLS Supported Groups)represented as defined by RFC 8422-Section 5.1.1 andhttps
        /// //www.openssl.org/docs/man1.1.0/man3/SSL_CTX_set1_curves.html. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ec_named_curve")]
        public string? EcNamedCurve { get; set; }
        /// <summary>
        /// Enable early data processing for TLS1.3 connections. Field introduced in 18.2.6. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_early_data")]
        public bool? EnableEarlyData { get; set; }
        /// <summary>
        /// Enable SSL session re-use.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssl_session_reuse")]
        public bool? EnableSslSessionReuse { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Prefer the SSL cipher ordering presented by the client during the SSL handshake over the one specified in the SSL
        /// Profile.
        /// </summary>
        [JsonProperty(PropertyName = "prefer_client_cipher_ordering")]
        public bool? PreferClientCipherOrdering { get; set; }
        /// <summary>
        /// Send 'close notify' alert message for a clean shutdown of the SSL connection.
        /// </summary>
        [JsonProperty(PropertyName = "send_close_notify")]
        public bool? SendCloseNotify { get; set; }
        /// <summary>
        /// Signature Algorithms represented as defined by RFC5246-Section 7.4.1.4.1 andhttps
        /// //www.openssl.org/docs/man1.1.0/man3/SSL_CTX_set1_client_sigalgs_list.html. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "signature_algorithm")]
        public string? SignatureAlgorithm { get; set; }
        /// <summary>
        /// Placeholder for description of property ssl_rating of obj type SSLProfile field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ssl_rating")]
        public NSXTALBSSLRatingType SslRating { get; set; }
        /// <summary>
        /// The amount of time in seconds before an SSL session expires. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_session_timeout")]
        public int? SslSessionTimeout { get; set; }
        /// <summary>
        /// Placeholder for description of property tags of obj type SSLProfile field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<NSXTALBTagType> Tags { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// SSL Profile Type. Enum options - SSL_PROFILE_TYPE_APPLICATION, SSL_PROFILE_TYPE_SYSTEM. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
