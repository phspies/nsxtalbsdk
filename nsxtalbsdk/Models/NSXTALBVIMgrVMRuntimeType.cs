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
    public class NSXTALBVIMgrVMRuntimeType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// availability_zone of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// connection_state of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "connection_state")]
        public string? ConnectionState { get; set; }
        /// <summary>
        /// Unique object identifier of controller_cluster.
        /// </summary>
        [JsonProperty(PropertyName = "controller_cluster_uuid")]
        public string? ControllerClusterUuid { get; set; }
        /// <summary>
        /// controller_ip_addr of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "controller_ip_addr")]
        public string? ControllerIpAddr { get; set; }
        /// <summary>
        /// Placeholder for description of property controller_vm of obj type VIMgrVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "controller_vm")]
        public bool? ControllerVm { get; set; }
        /// <summary>
        /// Number of cpu_reservation.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_reservation")]
        public long? CpuReservation { get; set; }
        /// <summary>
        /// Number of cpu_shares.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_shares")]
        public int? CpuShares { get; set; }
        /// <summary>
        /// Placeholder for description of property creation_in_progress of obj type VIMgrVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "creation_in_progress")]
        public bool? CreationInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property guest_nic of obj type VIMgrVMRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "guest_nic")]
        public IList<NSXTALBVIMgrGuestNicRuntimeType> GuestNic { get; set; }
        /// <summary>
        /// host of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Number of init_vnics.
        /// </summary>
        [JsonProperty(PropertyName = "init_vnics")]
        public int? InitVnics { get; set; }
        /// <summary>
        /// managed_object_id of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "managed_object_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagedObjectId { get; set; }
        /// <summary>
        /// Number of mem_shares.
        /// </summary>
        [JsonProperty(PropertyName = "mem_shares")]
        public int? MemShares { get; set; }
        /// <summary>
        /// Number of memory.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public long? Memory { get; set; }
        /// <summary>
        /// Number of memory_reservation.
        /// </summary>
        [JsonProperty(PropertyName = "memory_reservation")]
        public long? MemoryReservation { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Number of num_cpu.
        /// </summary>
        [JsonProperty(PropertyName = "num_cpu")]
        public int? NumCpu { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1,17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ovf_avisetype_field")]
        public string? OvfAvisetypeField { get; set; }
        /// <summary>
        /// powerstate of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "powerstate")]
        public string? Powerstate { get; set; }
        /// <summary>
        /// Number of se_ver.
        /// </summary>
        [JsonProperty(PropertyName = "se_ver")]
        public int? SeVer { get; set; }
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
        /// Unique object identifier of vcenter_datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_datacenter_uuid")]
        public string? VcenterDatacenterUuid { get; set; }
        /// <summary>
        /// vcenter_rm_cookie of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_rm_cookie")]
        public string? VcenterRmCookie { get; set; }
        /// <summary>
        /// Enum options - VIMGR_SE_NETWORK_ADMIN, VIMGR_SE_UNIFIED_ADMIN.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_se_type")]
        public string? VcenterSeType { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_template_vm of obj type VIMgrVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_template_vm")]
        public bool? VcenterTemplateVm { get; set; }
        /// <summary>
        /// vcenter_vAppName of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vAppName")]
        public string? VcenterVAppName { get; set; }
        /// <summary>
        /// vcenter_vAppVendor of VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vAppVendor")]
        public string? VcenterVAppVendor { get; set; }
        /// <summary>
        /// Enum options - VMTYPE_SE_VM, VMTYPE_POOL_SRVR.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vm_type")]
        public string? VcenterVmType { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_vnic_discovered of obj type VIMgrVMRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vnic_discovered")]
        public bool? VcenterVnicDiscovered { get; set; }
        /// <summary>
        /// Number of vm_lb_weight.
        /// </summary>
        [JsonProperty(PropertyName = "vm_lb_weight")]
        public int? VmLbWeight { get; set; }
    }
}
