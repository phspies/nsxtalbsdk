using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerCloudLimitsType
    {
        /// <summary>
        /// Maximum number of clouds of a given type. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_clouds")]
        public int? NumClouds { get; set; }
        /// <summary>
        /// Cloud type for the limit. Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA, CLOUD_APIC,
        /// CLOUD_MESOS, CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
