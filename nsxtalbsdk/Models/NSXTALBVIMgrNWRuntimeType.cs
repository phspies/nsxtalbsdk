using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIMgrNWRuntimeType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_vrf_context")]
        public string? ApicVrfContext { get; set; }
        /// <summary>
        /// Placeholder for description of property auto_expand of obj type VIMgrNWRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "auto_expand")]
        public bool? AutoExpand { get; set; }
        /// <summary>
        /// availability_zone of VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Unique object identifier of datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter_uuid")]
        public string? DatacenterUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property dvs of obj type VIMgrNWRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "dvs")]
        public bool? Dvs { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host_refs")]
        public IList<string> HostRefs { get; set; }
        /// <summary>
        /// Placeholder for description of property interested_nw of obj type VIMgrNWRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "interested_nw")]
        public bool? InterestedNw { get; set; }
        /// <summary>
        /// Placeholder for description of property ip_subnet of obj type VIMgrNWRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_subnet")]
        public IList<NSXTALBVIMgrIPSubnetRuntimeType> IpSubnet { get; set; }
        /// <summary>
        /// managed_object_id of VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "managed_object_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagedObjectId { get; set; }
        /// <summary>
        /// Placeholder for description of property MgmtNW of obj type VIMgrNWRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "MgmtNW")]
        public bool? MgmtNW { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Number of num_ports.
        /// </summary>
        [JsonProperty(PropertyName = "num_ports")]
        public int? NumPorts { get; set; }
        /// <summary>
        /// switch_name of VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "switch_name")]
        public string? SwitchName { get; set; }
        /// <summary>
        /// tenant_name of VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name")]
        public string? TenantName { get; set; }
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
        /// <summary>
        /// Number of vlan.
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public int? Vlan { get; set; }
        /// <summary>
        /// Placeholder for description of property vlan_range of obj type VIMgrNWRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vlan_range")]
        public IList<NSXTALBVlanRangeType> VlanRange { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vm_refs")]
        public IList<string> VmRefs { get; set; }
        /// <summary>
        /// It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_ref")]
        public string? VrfContextRef { get; set; }
    }
}
