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
    public class NSXTALBCloudSyncServicesType 
    {
        public NSXTALBCloudSyncServicesType()
        {
        }
        /// <summary>
        /// cc_id of CloudSyncServices.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of CloudSyncServices.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Unique object identifier of se_vm.
        /// </summary>
        [JsonProperty(PropertyName = "se_vm_uuid")]
        public string? SeVmUuid { get; set; }
        /// <summary>
        /// List of vips. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "vips")]
        public IList<NSXTALBIpAddrType> Vips { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "vtype")]
        public string? Vtype { get; set; }
    }
}
