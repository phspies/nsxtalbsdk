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
    public class NSXTALBMicroServiceType 
    {
        public NSXTALBMicroServiceType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// application_name of MicroService.
        /// </summary>
        [JsonProperty(PropertyName = "application_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ApplicationName { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for Microservice. Internally set by cloud connector. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// The list of containers for this microservice.
        /// </summary>
        [JsonProperty(PropertyName = "containers")]
        public IList<NSXTALBMicroServiceContainerType> Containers { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Flag to indicate if container IP list is provided by cloud connectorThis is applicable for overlay cases.
        /// </summary>
        [JsonProperty(PropertyName = "ip_list")]
        public bool? IpList { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// orchestrator_name of MicroService.
        /// </summary>
        [JsonProperty(PropertyName = "orchestrator_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string OrchestratorName { get; set; }
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
