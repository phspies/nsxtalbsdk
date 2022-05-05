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
    public class NSXTALBSslScoreDataType 
    {
        /// <summary>
        /// Chains for all certificates are verified.
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain_verified")]
        public string? CertChainVerified { get; set; }
        /// <summary>
        /// Score  Chains for all certificates are verified.
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain_verified_score")]
        public double? CertChainVerifiedScore { get; set; }
        /// <summary>
        /// Certificate revoked status by OCSP Responder.
        /// </summary>
        [JsonProperty(PropertyName = "cert_revoked_status")]
        public string? CertRevokedStatus { get; set; }
        /// <summary>
        /// Score  Certficate Revoked for VS.
        /// </summary>
        [JsonProperty(PropertyName = "cert_revoked_status_score")]
        public double? CertRevokedStatusScore { get; set; }
        /// <summary>
        /// Deactivate client renegotiation. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_client_renegotiation")]
        public bool? DeactivateClientRenegotiation { get; set; }
        /// <summary>
        /// Score  Deactivate client renegotiation. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "deactivate_client_renegotiation_score")]
        public double? DeactivateClientRenegotiationScore { get; set; }
        /// <summary>
        /// Disable client renegotiation. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_client_renegotiation")]
        public bool? DisableClientRenegotiation { get; set; }
        /// <summary>
        /// Score  Disable client renegotiation. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "disable_client_renegotiation_score")]
        public double? DisableClientRenegotiationScore { get; set; }
        /// <summary>
        /// Earliest certificate expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "earliest_cert_expiry")]
        public string? EarliestCertExpiry { get; set; }
        /// <summary>
        /// Score  Earliest certificate expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "earliest_cert_expiry_score")]
        public double? EarliestCertExpiryScore { get; set; }
        /// <summary>
        /// HSTS enabled for VS.
        /// </summary>
        [JsonProperty(PropertyName = "hsts_enabled")]
        public bool? HstsEnabled { get; set; }
        /// <summary>
        /// Score  HSTS enabled for VS.
        /// </summary>
        [JsonProperty(PropertyName = "hsts_enabled_score")]
        public double? HstsEnabledScore { get; set; }
        /// <summary>
        /// Strength of the weakest symmetric encryption algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "min_cipher_strength")]
        public string? MinCipherStrength { get; set; }
        /// <summary>
        /// Score  Strength of the weakest symmetric encryption algorithm.
        /// </summary>
        [JsonProperty(PropertyName = "min_cipher_strength_score")]
        public double? MinCipherStrengthScore { get; set; }
        /// <summary>
        /// Weakest SSL protocol supported.
        /// </summary>
        [JsonProperty(PropertyName = "min_ssl_protocol_strength")]
        public string? MinSslProtocolStrength { get; set; }
        /// <summary>
        /// Score  Weakest SSL protocol supported.
        /// </summary>
        [JsonProperty(PropertyName = "min_ssl_protocol_strength_score")]
        public double? MinSslProtocolStrengthScore { get; set; }
        /// <summary>
        /// Is a PFS cipher suite supported.
        /// </summary>
        [JsonProperty(PropertyName = "pfs_support")]
        public bool? PfsSupport { get; set; }
        /// <summary>
        /// Score  Is a PFS cipher suite supported.
        /// </summary>
        [JsonProperty(PropertyName = "pfs_support_score")]
        public double? PfsSupportScore { get; set; }
        /// <summary>
        /// Reason for the SSL Config Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the SSL Config Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Set whether the SSL service is enabled for the VS.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_enabled")]
        public bool? SslEnabled { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type SslScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }
        /// <summary>
        /// Weak algorithm used for signing the certificate, amongst all certificates for the VS.
        /// </summary>
        [JsonProperty(PropertyName = "weak_signature_algorithm")]
        public string? WeakSignatureAlgorithm { get; set; }
        /// <summary>
        /// Score  Weak algorithm used for signing the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "weak_signature_algorithm_score")]
        public double? WeakSignatureAlgorithmScore { get; set; }
        /// <summary>
        /// Weakest algorithm for symmetric encryption.
        /// </summary>
        [JsonProperty(PropertyName = "weakest_enc_algo")]
        public string? WeakestEncAlgo { get; set; }
        /// <summary>
        /// Score  Weakest algorithm for symmetric encryption.
        /// </summary>
        [JsonProperty(PropertyName = "weakest_enc_algo_score")]
        public double? WeakestEncAlgoScore { get; set; }
    }
}
