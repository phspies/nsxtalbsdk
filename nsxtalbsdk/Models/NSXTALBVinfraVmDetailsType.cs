using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVinfraVmDetailsType
    {
        /// <summary>
        /// datacenter of VinfraVmDetails.
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        public string? Datacenter { get; set; }
        /// <summary>
        /// host of VinfraVmDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
