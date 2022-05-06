using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceEngineType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// availability_zone of ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Placeholder for description of property container_mode of obj type ServiceEngine field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "container_mode")]
        public bool? ContainerMode { get; set; }
        /// <summary>
        /// Enum options - CONTAINER_TYPE_BRIDGE, CONTAINER_TYPE_HOST, CONTAINER_TYPE_HOST_DPDK.
        /// </summary>
        [JsonProperty(PropertyName = "container_type")]
        public string? ContainerType { get; set; }
        /// <summary>
        /// Placeholder for description of property controller_created of obj type ServiceEngine field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "controller_created")]
        public bool? ControllerCreated { get; set; }
        /// <summary>
        /// controller_ip of ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "controller_ip")]
        public string? ControllerIp { get; set; }
        /// <summary>
        /// Placeholder for description of property data_vnics of obj type ServiceEngine field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "data_vnics")]
        public IList<NSXTALBvNICType> DataVnics { get; set; }
        /// <summary>
        /// inorder to disable SE set this field appropriately. Enum options - SE_STATE_ENABLED, SE_STATE_DISABLED_FOR_PLACEMENT,
        /// SE_STATE_DISABLED, SE_STATE_DISABLED_FORCE.
        /// </summary>
        [JsonProperty(PropertyName = "enable_state")]
        public string? EnableState { get; set; }
        /// <summary>
        /// flavor of ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "flavor")]
        public string? Flavor { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host_ref")]
        public string? HostRef { get; set; }
        /// <summary>
        /// Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor")]
        public string? Hypervisor { get; set; }
        /// <summary>
        /// Placeholder for description of property mgmt_vnic of obj type ServiceEngine field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_vnic")]
        public NSXTALBvNICType MgmtVnic { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property resources of obj type ServiceEngine field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public NSXTALBSeResourcesType Resources { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngineGroup.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        public string? SeGroupRef { get; set; }
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
