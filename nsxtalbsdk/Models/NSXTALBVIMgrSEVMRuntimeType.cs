using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIMgrSEVMRuntimeType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// availability_zone of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "azure_info")]
        public NSXTALBAzureInfoType AzureInfo { get; set; }
        /// <summary>
        /// cloud_name of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// ServiceEngine deployed on cluster.Ex MOB  domain-c23. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_id")]
        public string? ClusterId { get; set; }
        /// <summary>
        /// ServiceEngine added to cluster vmgroup. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_vmgroup")]
        public string? ClusterVmgroup { get; set; }
        /// <summary>
        /// connection_state of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "connection_state")]
        public string? ConnectionState { get; set; }
        /// <summary>
        /// Unique object identifier of controller_cluster.
        /// </summary>
        [JsonProperty(PropertyName = "controller_cluster_uuid")]
        public string? ControllerClusterUuid { get; set; }
        /// <summary>
        /// controller_ip_addr of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "controller_ip_addr")]
        public string? ControllerIpAddr { get; set; }
        /// <summary>
        /// Service Engine Cookie set by the resource manager. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        public string? Cookie { get; set; }
        /// <summary>
        /// Placeholder for description of property creation_in_progress of obj type VIMgrSEVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "creation_in_progress")]
        public bool? CreationInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property deletion_in_progress of obj type VIMgrSEVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "deletion_in_progress")]
        public bool? DeletionInProgress { get; set; }
        /// <summary>
        /// discovery_response of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "discovery_response")]
        public string? DiscoveryResponse { get; set; }
        /// <summary>
        /// Number of discovery_status.
        /// </summary>
        [JsonProperty(PropertyName = "discovery_status")]
        public int? DiscoveryStatus { get; set; }
        /// <summary>
        /// Disk space in GB for each service engine VM. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "disk_gb")]
        public int? DiskGb { get; set; }
        /// <summary>
        /// flavor of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "flavor")]
        public string? Flavor { get; set; }
        /// <summary>
        /// GCP Project ID in which SE is created. This field is applicable for GCP cloud type only. Field introduced in 20.1.7,
        /// 21.1.2, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gcp_se_project_id")]
        public string? GcpSeProjectId { get; set; }
        /// <summary>
        /// Placeholder for description of property guest_nic of obj type VIMgrSEVMRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "guest_nic")]
        public IList<NSXTALBVIMgrGuestNicRuntimeType> GuestNic { get; set; }
        /// <summary>
        /// host of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host_ref")]
        public string? HostRef { get; set; }
        /// <summary>
        /// hostid of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "hostid")]
        public string? Hostid { get; set; }
        /// <summary>
        /// Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "hypervisor")]
        public string? Hypervisor { get; set; }
        /// <summary>
        /// Number of init_vnics.
        /// </summary>
        [JsonProperty(PropertyName = "init_vnics")]
        public int? InitVnics { get; set; }
        /// <summary>
        /// Number of last_discovery.
        /// </summary>
        [JsonProperty(PropertyName = "last_discovery")]
        public int? LastDiscovery { get; set; }
        /// <summary>
        /// managed_object_id of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "managed_object_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagedObjectId { get; set; }
        /// <summary>
        /// Memory in MB for each service engine VM. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "memory_mb")]
        public int? MemoryMb { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// powerstate of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "powerstate")]
        public string? Powerstate { get; set; }
        /// <summary>
        /// Unique object identifier of security_group.
        /// </summary>
        [JsonProperty(PropertyName = "security_group_uuid")]
        public string? SecurityGroupUuid { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngineGroup.
        /// </summary>
        [JsonProperty(PropertyName = "segroup_ref")]
        public string? SegroupRef { get; set; }
        /// <summary>
        /// Unique object identifier of server_group.
        /// </summary>
        [JsonProperty(PropertyName = "server_group_uuid")]
        public string? ServerGroupUuid { get; set; }
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
        /// Unique object identifier of vcenter_datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_datacenter_uuid")]
        public string? VcenterDatacenterUuid { get; set; }
        /// <summary>
        /// ServiceEngine host connection state in vCenter. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_host_connection_state")]
        public string? VcenterHostConnectionState { get; set; }
        /// <summary>
        /// VCenter Host HA state.Ex  election, fdmUnreachable, hostDown, initializationError, networkIsolated,
        /// uninitializationError, uninitialized. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_host_ha_state")]
        public string? VcenterHostHaState { get; set; }
        /// <summary>
        /// ServiceEngine instance uuid from vCenter. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_instance_uuid")]
        public string? VcenterInstanceUuid { get; set; }
        /// <summary>
        /// ServiceEngine belongs to VCenter. It is a reference to an object of type VCenterServer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_ref")]
        public string? VcenterRef { get; set; }
        /// <summary>
        /// vcenter_rm_cookie of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_rm_cookie")]
        public string? VcenterRmCookie { get; set; }
        /// <summary>
        /// Enum options - VIMGR_SE_NETWORK_ADMIN, VIMGR_SE_UNIFIED_ADMIN.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_se_type")]
        public string? VcenterSeType { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_template_vm of obj type VIMgrSEVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_template_vm")]
        public bool? VcenterTemplateVm { get; set; }
        /// <summary>
        /// Service Engine deployed in vcenter. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url")]
        public string? VcenterUrl { get; set; }
        /// <summary>
        /// vcenter_vAppName of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vAppName")]
        public string? VcenterVAppName { get; set; }
        /// <summary>
        /// vcenter_vAppVendor of VIMgrSEVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vAppVendor")]
        public string? VcenterVAppVendor { get; set; }
        /// <summary>
        /// Enum options - VMTYPE_SE_VM, VMTYPE_POOL_SRVR.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vm_type")]
        public string? VcenterVmType { get; set; }
        /// <summary>
        /// Count of vcpus for each service engine VM. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "vcpus")]
        public int? Vcpus { get; set; }
        /// <summary>
        /// VSphere HA on cluster enabled or not. Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_enabled")]
        public bool? VsphereHaEnabled { get; set; }
        /// <summary>
        /// If this flag is set to True, vCenter vSphere HA handles ServiceEngine failure. This flag is set dynamiclly based on
        /// underlying ESX HA state(connected, hostDown..etc). Field introduced in 20.1.7, 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_ha_inprogress")]
        public bool? VsphereHaInprogress { get; set; }
    }
}
