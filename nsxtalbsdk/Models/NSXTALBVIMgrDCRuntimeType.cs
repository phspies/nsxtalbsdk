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
    public class NSXTALBVIMgrDCRuntimeType 
    {
        public NSXTALBVIMgrDCRuntimeType()
        {
        }
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
        /// It is a reference to an object of type VIMgrClusterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_refs")]
        public IList<string> ClusterRefs { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host_refs")]
        public IList<string> HostRefs { get; set; }
        /// <summary>
        /// Placeholder for description of property interested_hosts of obj type VIMgrDCRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "interested_hosts")]
        public IList<NSXTALBVIMgrInterestedEntityType> InterestedHosts { get; set; }
        /// <summary>
        /// Placeholder for description of property interested_nws of obj type VIMgrDCRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "interested_nws")]
        public IList<NSXTALBVIMgrInterestedEntityType> InterestedNws { get; set; }
        /// <summary>
        /// Placeholder for description of property interested_vms of obj type VIMgrDCRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "interested_vms")]
        public IList<NSXTALBVIMgrInterestedEntityType> InterestedVms { get; set; }
        /// <summary>
        /// Number of inventory_state.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_state")]
        public int? InventoryState { get; set; }
        /// <summary>
        /// managed_object_id of VIMgrDCRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "managed_object_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagedObjectId { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "nw_refs")]
        public IList<string> NwRefs { get; set; }
        /// <summary>
        /// Number of pending_vcenter_reqs.
        /// </summary>
        [JsonProperty(PropertyName = "pending_vcenter_reqs")]
        public int? PendingVcenterReqs { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "sevm_refs")]
        public IList<string> SevmRefs { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
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
        /// <summary>
        /// Unique object identifier of vcenter.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_uuid")]
        public string? VcenterUuid { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vm_refs")]
        public IList<string> VmRefs { get; set; }
    }
}
