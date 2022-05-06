using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLCertificateType
    {
        /// <summary>
        /// certificate of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
        /// <summary>
        /// certificate_signing_request of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_signing_request")]
        public string? CertificateSigningRequest { get; set; }
        /// <summary>
        /// Placeholder for description of property chain_verified of obj type SSLCertificate field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "chain_verified")]
        public bool? ChainVerified { get; set; }
        /// <summary>
        /// Number of days_until_expire.
        /// </summary>
        [JsonProperty(PropertyName = "days_until_expire")]
        public int? DaysUntilExpire { get; set; }
        /// <summary>
        /// Enum options - SSL_CERTIFICATE_GOOD, SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_status")]
        public string? ExpiryStatus { get; set; }
        /// <summary>
        /// fingerprint of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        public string? Fingerprint { get; set; }
        /// <summary>
        /// Placeholder for description of property issuer of obj type SSLCertificate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public NSXTALBSSLCertificateDescriptionType Issuer { get; set; }
        /// <summary>
        /// Placeholder for description of property key_params of obj type SSLCertificate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "key_params")]
        public NSXTALBSSLKeyParamsType KeyParams { get; set; }
        /// <summary>
        /// not_after of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "not_after")]
        public string? NotAfter { get; set; }
        /// <summary>
        /// not_before of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "not_before")]
        public string? NotBefore { get; set; }
        /// <summary>
        /// public_key of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "public_key")]
        public string? PublicKey { get; set; }
        /// <summary>
        /// Placeholder for description of property self_signed of obj type SSLCertificate field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "self_signed")]
        public bool? SelfSigned { get; set; }
        /// <summary>
        /// serial_number of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "serial_number")]
        public string? SerialNumber { get; set; }
        /// <summary>
        /// signature of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        public string? Signature { get; set; }
        /// <summary>
        /// signature_algorithm of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature_algorithm")]
        public string? SignatureAlgorithm { get; set; }
        /// <summary>
        /// Placeholder for description of property subject of obj type SSLCertificate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public NSXTALBSSLCertificateDescriptionType Subject { get; set; }
        /// <summary>
        /// subjectAltName that provides additional subject identities.
        /// </summary>
        [JsonProperty(PropertyName = "subject_alt_names")]
        public IList<string> SubjectAltNames { get; set; }
        /// <summary>
        /// text of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string? Text { get; set; }
        /// <summary>
        /// version of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
