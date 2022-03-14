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
    public class NSXTALBPKIProfileType 
    {
        public NSXTALBPKIProfileType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// List of Certificate Authorities (Root and Intermediate) trusted that is used for certificate validation.
        /// </summary>
        [JsonProperty(PropertyName = "ca_certs")]
        public IList<NSXTALBSSLCertificateType> CaCerts { get; set; }
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
        /// When enabled, Avi will verify via CRL checks that certificates in the trust chain have not been revoked.
        /// </summary>
        [JsonProperty(PropertyName = "crl_check")]
        public bool? CrlCheck { get; set; }
        /// <summary>
        /// Certificate Revocation Lists.
        /// </summary>
        [JsonProperty(PropertyName = "crls")]
        public IList<NSXTALBCRLType> Crls { get; set; }
        /// <summary>
        /// When enabled, Avi will not trust Intermediate and Root certs presented by a client.  Instead, only the chain certs
        /// configured in the Certificate Authority section will be used to verify trust of the client's cert. Allowed in
        /// Basic(Allowed values- true) edition, Essentials(Allowed values- true) edition, Enterprise edition. Special default for
        /// Basic edition is true, Essentials edition is true, Enterprise is False.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_peer_chain")]
        public bool? IgnorePeerChain { get; set; }
        /// <summary>
        /// This field describes the object's replication scope. If the field is set to false, then the object is visible within the
        /// controller-cluster and its associated service-engines.  If the field is set to true, then the object is replicated
        /// across the federation.  . Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_federated")]
        public bool? IsFederated { get; set; }
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
        /// Name of the PKI Profile.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
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
        /// <summary>
        /// When enabled, Avi will only validate the revocation status of the leaf certificate using CRL. To enable validation for
        /// the entire chain, disable this option and provide all the relevant CRLs. Allowed in Basic(Allowed values- true) edition,
        /// Essentials(Allowed values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "validate_only_leaf_crl")]
        public bool? ValidateOnlyLeafCrl { get; set; }
    }
}
