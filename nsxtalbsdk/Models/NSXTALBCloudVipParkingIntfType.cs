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
    public class NSXTALBCloudVipParkingIntfType 
    {
        /// <summary>
        /// cc_id of CloudVipParkingIntf.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of CloudVipParkingIntf.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// intf_id of CloudVipParkingIntf.
        /// </summary>
        [JsonProperty(PropertyName = "intf_id")]
        public string? IntfId { get; set; }
        /// <summary>
        /// subnet_id of CloudVipParkingIntf.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SubnetId { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "vtype")]
        public string? Vtype { get; set; }
    }
}
