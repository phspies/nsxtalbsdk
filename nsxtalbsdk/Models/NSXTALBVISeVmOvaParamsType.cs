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
    public class NSXTALBVISeVmOvaParamsType 
    {
        /// <summary>
        /// Unique object identifier of controller_cluster.
        /// </summary>
        [JsonProperty(PropertyName = "controller_cluster_uuid")]
        public string? ControllerClusterUuid { get; set; }
        /// <summary>
        /// controller_ip_addr of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "controller_ip_addr", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ControllerIpAddr { get; set; }
        /// <summary>
        /// Enum options - APIC_MODE, NON_APIC_MODE.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// rm_cookie of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "rm_cookie")]
        public string? RmCookie { get; set; }
        /// <summary>
        /// se_auth_token of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_token")]
        public string? SeAuthToken { get; set; }
        /// <summary>
        /// sevm_name of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "sevm_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SevmName { get; set; }
        /// <summary>
        /// Placeholder for description of property single_socket_affinity of obj type VISeVmOvaParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "single_socket_affinity")]
        public bool? SingleSocketAffinity { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_cpu_reserv of obj type VISeVmOvaParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_cpu_reserv")]
        public bool? VcenterCpuReserv { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_ds_include of obj type VISeVmOvaParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_ds_include")]
        public bool? VcenterDsInclude { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_ds_info of obj type VISeVmOvaParams field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_ds_info")]
        public IList<NSXTALBVcenterDatastoreType> VcenterDsInfo { get; set; }
        /// <summary>
        /// Enum options - VCENTER_DATASTORE_ANY, VCENTER_DATASTORE_LOCAL, VCENTER_DATASTORE_SHARED.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_ds_mode")]
        public string? VcenterDsMode { get; set; }
        /// <summary>
        /// vcenter_host of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_host")]
        public string? VcenterHost { get; set; }
        /// <summary>
        /// vcenter_internal of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_internal")]
        public string? VcenterInternal { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_mem_reserv of obj type VISeVmOvaParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_mem_reserv")]
        public bool? VcenterMemReserv { get; set; }
        /// <summary>
        /// Number of vcenter_num_mem.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_num_mem")]
        public long? VcenterNumMem { get; set; }
        /// <summary>
        /// Number of vcenter_num_se_cores.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_num_se_cores")]
        public int? VcenterNumSeCores { get; set; }
        /// <summary>
        /// vcenter_opaque_nwid of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_opaque_nwid")]
        public string? VcenterOpaqueNwid { get; set; }
        /// <summary>
        /// vcenter_ovf_path of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_ovf_path")]
        public string? VcenterOvfPath { get; set; }
        /// <summary>
        /// Number of vcenter_se_disk_size_KB.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_se_disk_size_KB")]
        public int? VcenterSeDiskSizeKB { get; set; }
        /// <summary>
        /// vcenter_se_mgmt_nw of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_se_mgmt_nw")]
        public string? VcenterSeMgmtNw { get; set; }
        /// <summary>
        /// vcenter_vm_folder of VISeVmOvaParams.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vm_folder")]
        public string? VcenterVmFolder { get; set; }
    }
}
