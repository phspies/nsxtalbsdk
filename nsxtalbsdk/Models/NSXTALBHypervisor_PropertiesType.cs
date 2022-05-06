using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHypervisor_PropertiesType
    {
        /// <summary>
        /// Enum options - DEFAULT, VMWARE_ESX, KVM, VMWARE_VSAN, XEN.
        /// </summary>
        [JsonProperty(PropertyName = "htype")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Htype { get; set; }
        /// <summary>
        /// Number of max_ips_per_nic.
        /// </summary>
        [JsonProperty(PropertyName = "max_ips_per_nic")]
        public int? MaxIpsPerNic { get; set; }
        /// <summary>
        /// Number of max_nics.
        /// </summary>
        [JsonProperty(PropertyName = "max_nics")]
        public int? MaxNics { get; set; }
    }
}
