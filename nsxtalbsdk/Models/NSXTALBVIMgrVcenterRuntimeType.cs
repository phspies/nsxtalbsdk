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
    public class NSXTALBVIMgrVcenterRuntimeType 
    {
        public NSXTALBVIMgrVcenterRuntimeType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// api_version of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "api_version")]
        public string? ApiVersion { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "apic_mode")]
        public bool? ApicMode { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrDCRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter_refs")]
        public IList<string> DatacenterRefs { get; set; }
        /// <summary>
        /// disc_end_time of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "disc_end_time")]
        public string? DiscEndTime { get; set; }
        /// <summary>
        /// disc_start_time of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "disc_start_time")]
        public string? DiscStartTime { get; set; }
        /// <summary>
        /// discovered_datacenter of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_datacenter")]
        public string? DiscoveredDatacenter { get; set; }
        /// <summary>
        /// inventory_progress of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_progress")]
        public string? InventoryProgress { get; set; }
        /// <summary>
        /// Enum options - VCENTER_DISCOVERY_BAD_CREDENTIALS, VCENTER_DISCOVERY_RETRIEVING_DC, VCENTER_DISCOVERY_WAITING_DC,
        /// VCENTER_DISCOVERY_RETRIEVING_NW, VCENTER_DISCOVERY_ONGOING, VCENTER_DISCOVERY_RESYNCING, VCENTER_DISCOVERY_COMPLETE,
        /// VCENTER_DISCOVERY_DELETING_VCENTER, VCENTER_DISCOVERY_FAILURE, VCENTER_DISCOVERY_COMPLETE_NO_MGMT_NW,
        /// VCENTER_DISCOVERY_COMPLETE_PER_TENANT_IP_ROUTE, VCENTER_DISCOVERY_MAKING_SE_OVA, VCENTER_DISCOVERY_RESYNC_FAILED,
        /// VCENTER_DISCOVERY_OBJECT_LIMIT_REACHED.
        /// </summary>
        [JsonProperty(PropertyName = "inventory_state")]
        public string? InventoryState { get; set; }
        /// <summary>
        /// management_network of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "management_network")]
        public string? ManagementNetwork { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Number of num_clusters.
        /// </summary>
        [JsonProperty(PropertyName = "num_clusters")]
        public long? NumClusters { get; set; }
        /// <summary>
        /// Number of num_dcs.
        /// </summary>
        [JsonProperty(PropertyName = "num_dcs")]
        public long? NumDcs { get; set; }
        /// <summary>
        /// Number of num_hosts.
        /// </summary>
        [JsonProperty(PropertyName = "num_hosts")]
        public long? NumHosts { get; set; }
        /// <summary>
        /// Number of num_nws.
        /// </summary>
        [JsonProperty(PropertyName = "num_nws")]
        public long? NumNws { get; set; }
        /// <summary>
        /// Number of num_vcenter_req_pending.
        /// </summary>
        [JsonProperty(PropertyName = "num_vcenter_req_pending")]
        public long? NumVcenterReqPending { get; set; }
        /// <summary>
        /// Number of num_vms.
        /// </summary>
        [JsonProperty(PropertyName = "num_vms")]
        public long? NumVms { get; set; }
        /// <summary>
        /// password of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// Enum options - NO_ACCESS, READ_ACCESS, WRITE_ACCESS.
        /// </summary>
        [JsonProperty(PropertyName = "privilege")]
        public string? Privilege { get; set; }
        /// <summary>
        /// Number of progress.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public long? Progress { get; set; }
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
        /// username of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_connected of obj type VIMgrVcenterRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_connected")]
        public bool? VcenterConnected { get; set; }
        /// <summary>
        /// vcenter_fullname of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_fullname")]
        public string? VcenterFullname { get; set; }
        /// <summary>
        /// vcenter_template_se_location of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_template_se_location")]
        public string? VcenterTemplateSeLocation { get; set; }
        /// <summary>
        /// vcenter_url of VIMgrVcenterRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_url", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcenterUrl { get; set; }
    }
}
