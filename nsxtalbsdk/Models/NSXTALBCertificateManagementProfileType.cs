using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCertificateManagementProfileType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.6. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Name of the PKI Profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Alert script config object for certificate management profile. It is a reference to an object of type AlertScriptConfig.
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "run_script_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RunScriptRef { get; set; }
        /// <summary>
        /// Placeholder for description of property script_params of obj type CertificateManagementProfile field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "script_params")]
        public IList<NSXTALBCustomParamsType> ScriptParams { get; set; }
        /// <summary>
        /// Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "script_path")]
        public string? ScriptPath { get; set; }
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
    }
}
