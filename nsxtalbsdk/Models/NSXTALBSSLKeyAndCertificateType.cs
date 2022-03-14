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
    public class NSXTALBSSLKeyAndCertificateType 
    {
        public NSXTALBSSLKeyAndCertificateType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// CA certificates in certificate chain.
        /// </summary>
        [JsonProperty(PropertyName = "ca_certs")]
        public IList<NSXTALBCertificateAuthorityType> CaCerts { get; set; }
        /// <summary>
        /// Placeholder for description of property certificate of obj type SSLKeyAndCertificate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBSSLCertificateType Certificate { get; set; }
        /// <summary>
        /// States if the certificate is base64 encoded.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_base64")]
        public bool? CertificateBase64 { get; set; }
        /// <summary>
        /// It is a reference to an object of type CertificateManagementProfile.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_management_profile_ref")]
        public string? CertificateManagementProfileRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Dynamic parameters needed for certificate management profile.
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_params")]
        public IList<NSXTALBCustomParamsType> DynamicParams { get; set; }
        /// <summary>
        /// Enables OCSP Stapling. Field introduced in 20.1.1. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed
        /// values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ocsp_stapling")]
        public bool? EnableOcspStapling { get; set; }
        /// <summary>
        /// Encrypted private key corresponding to the private key (e.g. those generated by an HSM such as Thales nShield).
        /// </summary>
        [JsonProperty(PropertyName = "enckey_base64")]
        public string? EnckeyBase64 { get; set; }
        /// <summary>
        /// Name of the encrypted private key (e.g. those generated by an HSM such as Thales nShield).
        /// </summary>
        [JsonProperty(PropertyName = "enckey_name")]
        public string? EnckeyName { get; set; }
        /// <summary>
        /// Format of the Key/Certificate file. Enum options - SSL_PEM, SSL_PKCS12.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string? Format { get; set; }
        /// <summary>
        /// It is a reference to an object of type HardwareSecurityModuleGroup.
        /// </summary>
        [JsonProperty(PropertyName = "hardwaresecuritymodulegroup_ref")]
        public string? HardwaresecuritymodulegroupRef { get; set; }
        /// <summary>
        /// Private key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// States if the private key is base64 encoded.
        /// </summary>
        [JsonProperty(PropertyName = "key_base64")]
        public bool? KeyBase64 { get; set; }
        /// <summary>
        /// Placeholder for description of property key_params of obj type SSLKeyAndCertificate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "key_params")]
        public NSXTALBSSLKeyParamsType KeyParams { get; set; }
        /// <summary>
        /// Passphrase used to encrypt the private key.
        /// </summary>
        [JsonProperty(PropertyName = "key_passphrase")]
        public string? KeyPassphrase { get; set; }
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
        /// Configuration related to OCSP. Field introduced in 20.1.1. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_config")]
        public NSXTALBOCSPConfigType OcspConfig { get; set; }
        /// <summary>
        /// Error reported during OCSP status query. Enum options - OCSP_ERR_CERTSTATUS_GOOD, OCSP_ERR_CERTSTATUS_REVOKED,
        /// OCSP_ERR_CERTSTATUS_UNKNOWN, OCSP_ERR_CERTSTATUS_SERVERFAIL_ERR, OCSP_ERR_CERTSTATUS_JOBDB,
        /// OCSP_ERR_CERTSTATUS_DISABLED, OCSP_ERR_CERTSTATUS_GETCERT, OCSP_ERR_CERTSTATUS_NONVSCERT,
        /// OCSP_ERR_CERTSTATUS_SELFSIGNED, OCSP_ERR_CERTSTATUS_CERTFINISH, OCSP_ERR_CERTSTATUS_CACERT, OCSP_ERR_CERTSTATUS_REQUEST,
        /// OCSP_ERR_CERTSTATUS_ISSUER_REVOKED, OCSP_ERR_CERTSTATUS_PARSE_CERT, OCSP_ERR_CERTSTATUS_HTTP_REQ,
        /// OCSP_ERR_CERTSTATUS_URL_LIST, OCSP_ERR_CERTSTATUS_HTTP_SEND, OCSP_ERR_CERTSTATUS_HTTP_RECV,
        /// OCSP_ERR_CERTSTATUS_HTTP_RESP. Field introduced in 20.1.1. Allowed in Basic(Allowed values-
        /// OCSP_ERR_CERTSTATUS_DISABLED) edition, Essentials(Allowed values- OCSP_ERR_CERTSTATUS_DISABLED) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_error_status")]
        public string? OcspErrorStatus { get; set; }
        /// <summary>
        /// This is an Internal field to store the OCSP Responder URLs contained in the certificate. Field introduced in 20.1.1.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_responder_url_list_from_certs")]
        public IList<string> OcspResponderUrlListFromCerts { get; set; }
        /// <summary>
        /// Information related to OCSP response. Field introduced in 20.1.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ocsp_response_info")]
        public NSXTALBOCSPResponseInfoType OcspResponseInfo { get; set; }
        /// <summary>
        /// Enum options - SSL_CERTIFICATE_FINISHED, SSL_CERTIFICATE_PENDING.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Enum options - SSL_CERTIFICATE_TYPE_VIRTUALSERVICE, SSL_CERTIFICATE_TYPE_SYSTEM, SSL_CERTIFICATE_TYPE_CA.
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
