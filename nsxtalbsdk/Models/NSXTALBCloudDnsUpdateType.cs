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
    public class NSXTALBCloudDnsUpdateType 
    {
        /// <summary>
        /// cc_id of CloudDnsUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// dns_fqdn of CloudDnsUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "dns_fqdn")]
        public string? DnsFqdn { get; set; }
        /// <summary>
        /// error_string of CloudDnsUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Placeholder for description of property fip of obj type CloudDnsUpdate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "fip")]
        public NSXTALBIpAddrType Fip { get; set; }
        /// <summary>
        /// Placeholder for description of property vip of obj type CloudDnsUpdate field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public NSXTALBIpAddrType Vip { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "vtype")]
        public string? Vtype { get; set; }
    }
}
