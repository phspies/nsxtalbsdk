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
    public class NSXTALBVIMgrGuestNicRuntimeType 
    {
        /// <summary>
        /// Placeholder for description of property avi_internal_network of obj type VIMgrGuestNicRuntime field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "avi_internal_network")]
        public bool? AviInternalNetwork { get; set; }
        /// <summary>
        /// Placeholder for description of property connected of obj type VIMgrGuestNicRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }
        /// <summary>
        /// Placeholder for description of property del_pending of obj type VIMgrGuestNicRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "del_pending")]
        public bool? DelPending { get; set; }
        /// <summary>
        /// Placeholder for description of property guest_ip of obj type VIMgrGuestNicRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "guest_ip")]
        public IList<NSXTALBVIMgrIPSubnetRuntimeType> GuestIp { get; set; }
        /// <summary>
        /// label of VIMgrGuestNicRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string? Label { get; set; }
        /// <summary>
        /// mac_addr of VIMgrGuestNicRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addr", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddr { get; set; }
        /// <summary>
        /// Placeholder for description of property mgmt_vnic of obj type VIMgrGuestNicRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_vnic")]
        public bool? MgmtVnic { get; set; }
        /// <summary>
        /// network_name of VIMgrGuestNicRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// Unique object identifier of network.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuid")]
        public string? NetworkUuid { get; set; }
        /// <summary>
        /// Unique object identifier of os_port.
        /// </summary>
        [JsonProperty(PropertyName = "os_port_uuid")]
        public string? OsPortUuid { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
