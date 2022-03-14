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
    public class NSXTALBCloudIpChangeType 
    {
        public NSXTALBCloudIpChangeType()
        {
        }
        /// <summary>
        /// cc_id of CloudIpChange.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of CloudIpChange.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Placeholder for description of property ip of obj type CloudIpChange field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public NSXTALBIpAddrType Ip6 { get; set; }
        /// <summary>
        /// Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_mask")]
        public int? Ip6Mask { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_mask")]
        public int? IpMask { get; set; }
        /// <summary>
        /// mac_addr of CloudIpChange.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addr")]
        public string? MacAddr { get; set; }
        /// <summary>
        /// Unique object identifier of port.
        /// </summary>
        [JsonProperty(PropertyName = "port_uuid")]
        public string? PortUuid { get; set; }
        /// <summary>
        /// Unique object identifier of se_vm.
        /// </summary>
        [JsonProperty(PropertyName = "se_vm_uuid")]
        public string? SeVmUuid { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "vtype")]
        public string? Vtype { get; set; }
    }
}
