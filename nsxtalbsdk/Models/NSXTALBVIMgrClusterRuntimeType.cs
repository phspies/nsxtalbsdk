using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIMgrClusterRuntimeType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// datacenter_managed_object_id of VIMgrClusterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter_managed_object_id")]
        public string? DatacenterManagedObjectId { get; set; }
        /// <summary>
        /// Unique object identifier of datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter_uuid")]
        public string? DatacenterUuid { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host_refs")]
        public IList<string> HostRefs { get; set; }
        /// <summary>
        /// managed_object_id of VIMgrClusterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "managed_object_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagedObjectId { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
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
