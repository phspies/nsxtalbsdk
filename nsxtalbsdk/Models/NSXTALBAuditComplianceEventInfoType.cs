using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAuditComplianceEventInfoType
    {
        /// <summary>
        /// Cluster uuid used for controller event. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// Name of core archive. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "core_archive")]
        public string? CoreArchive { get; set; }
        /// <summary>
        /// Detailed report of the audit event. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "detailed_reason")]
        public string? DetailedReason { get; set; }
        /// <summary>
        /// Set the flag if event is generated by SE. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "event_generated_by_se")]
        public bool? EventGeneratedBySe { get; set; }
        /// <summary>
        /// Fingerprint extracted from the stacktrace. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        public string? Fingerprint { get; set; }
        /// <summary>
        /// Information identifying physical location for audit event (e.g. Santa Clara (USA), Bengaluru (India)). Field introduced
        /// in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string? Location { get; set; }
        /// <summary>
        /// Node on which crash is generated. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "node")]
        public string? Node { get; set; }
        /// <summary>
        /// Patch version of node. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
        /// <summary>
        /// Crashed core process name. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "process_name")]
        public string? ProcessName { get; set; }
        /// <summary>
        /// Protocol used for communication to the external entity. Enum options - SSH1_0, TLS1_2, HTTPS1_0, HTTP_PLAIN_TEXT,
        /// HTTPS_INSECURE, SSH2_0. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
        /// <summary>
        /// Summarized failure of the transaction (e.g. Invalid request, expired certificate). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Result { get; set; }
        /// <summary>
        /// Service Engine uuid used for service engine event. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// Subjects of audit event. Field introduced in 20.1.3. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "subjects")]
        public IList<NSXTALBACSubjectInfoType> Subjects { get; set; }
        /// <summary>
        /// Type of audit event. Enum options - AUDIT_INVALID_CREDENTIALS, AUDIT_NAME_RESOLUTION_ERROR, AUDIT_DIAL_X509_ERROR,
        /// AUDIT_CORE_GENERATED, AUDIT_SECURE_KEY_EXCHANGE_BAD_REQUEST_FORMAT, AUDIT_SECURE_KEY_EXCHANGE_BAD_CLIENT_TYPE,
        /// AUDIT_SECURE_KEY_EXCHANGE_FIELD_NOT_FOUND, AUDIT_SECURE_KEY_EXCHANGE_BAD_FIELD_VALUE,
        /// AUDIT_SECURE_KEY_EXCHANGE_INVALID_AUTHORIZATION, AUDIT_SECURE_KEY_EXCHANGE_INTERNAL_ERROR,
        /// AUDIT_SECURE_KEY_EXCHANGE_CERTIFICATE_VERIFY_ERROR, AUDIT_SECURE_KEY_EXCHANGE_RESPONSE_ERROR. Field introduced in
        /// 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// List of users (username etc) related to the audit event. Field introduced in 20.1.3. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "user_identities")]
        public IList<NSXTALBACUserIdentityType> UserIdentities { get; set; }
        /// <summary>
        /// Version tag of node. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
