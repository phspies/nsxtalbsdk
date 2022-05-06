using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCloudHealthType
    {
        /// <summary>
        /// cc_id of CloudHealth.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// error_string of CloudHealth.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// first_fail of CloudHealth.
        /// </summary>
        [JsonProperty(PropertyName = "first_fail")]
        public string? FirstFail { get; set; }
        /// <summary>
        /// last_fail of CloudHealth.
        /// </summary>
        [JsonProperty(PropertyName = "last_fail")]
        public string? LastFail { get; set; }
        /// <summary>
        /// last_ok of CloudHealth.
        /// </summary>
        [JsonProperty(PropertyName = "last_ok")]
        public string? LastOk { get; set; }
        /// <summary>
        /// Number of num_fails.
        /// </summary>
        [JsonProperty(PropertyName = "num_fails")]
        public int? NumFails { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// </summary>
        [JsonProperty(PropertyName = "vtype")]
        public string? Vtype { get; set; }
    }
}
