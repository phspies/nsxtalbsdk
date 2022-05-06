using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIGuestvNicIPAddrType
    {
        /// <summary>
        /// ip_addr of VIGuestvNicIPAddr.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpAddr { get; set; }
        /// <summary>
        /// Number of mask.
        /// </summary>
        [JsonProperty(PropertyName = "mask")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Mask { get; set; }
    }
}
