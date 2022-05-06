using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOCSPResponseInfoType
    {
        /// <summary>
        /// Revocation status of the certificate. Enum options - OCSP_CERTSTATUS_GOOD, OCSP_CERTSTATUS_REVOKED,
        /// OCSP_CERTSTATUS_UNKNOWN. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cert_status")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CertStatus { get; set; }
        /// <summary>
        /// The time at or before which newer information will be available about the status of the certificate. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "next_update")]
        public string? NextUpdate { get; set; }
        /// <summary>
        /// The OCSP Responder URL from which the response is received. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_resp_from_responder_url")]
        [System.ComponentModel.DataAnnotations.Required]
        public string OcspRespFromResponderUrl { get; set; }
        /// <summary>
        /// Signed OCSP response received from the CA's OCSP Responder. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_response")]
        [System.ComponentModel.DataAnnotations.Required]
        public string OcspResponse { get; set; }
        /// <summary>
        /// The reason for the revocation of the certificate. Enum options - OCSP_REVOCATION_REASON_UNSPECIFIED,
        /// OCSP_REVOCATION_REASON_KEY_COMPROMISE, OCSP_REVOCATION_REASON_CA_COMPROMISE, OCSP_REVOCATION_REASON_AFFILIATION_CHANGED,
        /// OCSP_REVOCATION_REASON_SUPERSEDED, OCSP_REVOCATION_REASON_CESSATION_OF_OPERATION,
        /// OCSP_REVOCATION_REASON_CERTIFICATE_HOLD, OCSP_REVOCATION_REASON_REMOVE_FROM_CRL,
        /// OCSP_REVOCATION_REASON_PRIVILEGE_WITHDRAWN, OCSP_REVOCATION_REASON_AA_COMPROMISE. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "revocation_reason")]
        public string? RevocationReason { get; set; }
        /// <summary>
        /// ISO 8601 compatible timestamp at which the certificate was revoked or placed on hold. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "revocation_time")]
        public string? RevocationTime { get; set; }
        /// <summary>
        /// The most recent time at which the status being indicated is known by the OCSP Responder to have been correct. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "this_update")]
        public string? ThisUpdate { get; set; }
    }
}
