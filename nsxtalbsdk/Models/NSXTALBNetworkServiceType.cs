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
    public class NSXTALBNetworkServiceType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
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
        /// Name of the NetworkService. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Routing Information of the NetworkService. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "routing_service")]
        public NSXTALBRoutingServiceType RoutingService { get; set; }
        /// <summary>
        /// Service Engine Group to which the service is applied. It is a reference to an object of type ServiceEngineGroup. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeGroupRef { get; set; }
        /// <summary>
        /// Indicates the type of NetworkService. Enum options - ROUTING_SERVICE. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ServiceType { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the NetworkService. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// VRF context to which the service is scoped. It is a reference to an object of type VrfContext. Field introduced in
        /// 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VrfRef { get; set; }
    }
}
