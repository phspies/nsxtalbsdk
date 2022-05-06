using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVsSeVnicType
    {
        /// <summary>
        /// lif of VsSeVnic.
        /// </summary>
        [JsonProperty(PropertyName = "lif")]
        public string? Lif { get; set; }
        /// <summary>
        /// mac of VsSeVnic.
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mac { get; set; }
        /// <summary>
        /// Enum options - VNIC_TYPE_FE, VNIC_TYPE_BE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
