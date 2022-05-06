using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVinfraVcenterDiscoveryFailureType
    {
        /// <summary>
        /// state of VinfraVcenterDiscoveryFailure.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [System.ComponentModel.DataAnnotations.Required]
        public string State { get; set; }
        /// <summary>
        /// vcenter of VinfraVcenterDiscoveryFailure.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
