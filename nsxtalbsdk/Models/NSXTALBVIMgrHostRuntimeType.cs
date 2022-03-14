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
    public class NSXTALBVIMgrHostRuntimeType 
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
        /// cluster_name of VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name")]
        public string? ClusterName { get; set; }
        /// <summary>
        /// Unique object identifier of cluster.
        /// </summary>
        [JsonProperty(PropertyName = "cluster_uuid")]
        public string? ClusterUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property cntlr_accessible of obj type VIMgrHostRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "cntlr_accessible")]
        public bool? CntlrAccessible { get; set; }
        /// <summary>
        /// connection_state of VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "connection_state")]
        public string? ConnectionState { get; set; }
        /// <summary>
        /// Number of cpu_hz.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_hz")]
        public long? CpuHz { get; set; }
        /// <summary>
        /// Placeholder for description of property maintenance_mode of obj type VIMgrHostRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        public bool? MaintenanceMode { get; set; }
        /// <summary>
        /// managed_object_id of VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "managed_object_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagedObjectId { get; set; }
        /// <summary>
        /// Number of mem.
        /// </summary>
        [JsonProperty(PropertyName = "mem")]
        public long? Mem { get; set; }
        /// <summary>
        /// mgmt_portgroup of VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_portgroup")]
        public string? MgmtPortgroup { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Unique object identifiers of networks.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuids")]
        public IList<string> NetworkUuids { get; set; }
        /// <summary>
        /// Number of num_cpu_cores.
        /// </summary>
        [JsonProperty(PropertyName = "num_cpu_cores")]
        public int? NumCpuCores { get; set; }
        /// <summary>
        /// Number of num_cpu_packages.
        /// </summary>
        [JsonProperty(PropertyName = "num_cpu_packages")]
        public int? NumCpuPackages { get; set; }
        /// <summary>
        /// Number of num_cpu_threads.
        /// </summary>
        [JsonProperty(PropertyName = "num_cpu_threads")]
        public int? NumCpuThreads { get; set; }
        /// <summary>
        /// Placeholder for description of property pnics of obj type VIMgrHostRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pnics")]
        public IList<NSXTALBCdpLldpInfoType> Pnics { get; set; }
        /// <summary>
        /// powerstate of VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "powerstate")]
        public string? Powerstate { get; set; }
        /// <summary>
        /// quarantine_start_ts of VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "quarantine_start_ts")]
        public string? QuarantineStartTs { get; set; }
        /// <summary>
        /// Placeholder for description of property quarantined of obj type VIMgrHostRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "quarantined")]
        public bool? Quarantined { get; set; }
        /// <summary>
        /// Number of quarantined_periods.
        /// </summary>
        [JsonProperty(PropertyName = "quarantined_periods")]
        public int? QuarantinedPeriods { get; set; }
        /// <summary>
        /// Number of se_fail_cnt.
        /// </summary>
        [JsonProperty(PropertyName = "se_fail_cnt")]
        public int? SeFailCnt { get; set; }
        /// <summary>
        /// Number of se_success_cnt.
        /// </summary>
        [JsonProperty(PropertyName = "se_success_cnt")]
        public int? SeSuccessCnt { get; set; }
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
        /// It is a reference to an object of type VIMgrVMRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vm_refs")]
        public IList<string> VmRefs { get; set; }
    }
}
