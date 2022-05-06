using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceEngineCloudLimitsType
    {
        /// <summary>
        /// Cloud type for this cloud limit. Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK, CLOUD_AWS, CLOUD_VCA,
        /// CLOUD_APIC, CLOUD_MESOS, CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER, CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP,
        /// CLOUD_NSXT. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Maximum number of vrfcontexts per serviceengine. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vrfs_per_serviceengine")]
        public int? VrfsPerServiceengine { get; set; }
    }
}
