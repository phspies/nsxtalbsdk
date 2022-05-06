using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIpAddrPrefixType
    {
        /// <summary>
        /// Placeholder for description of property ip_addr of obj type IpAddrPrefix field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddr { get; set; }
        /// <summary>
        /// Number of mask.
        /// </summary>
        [JsonProperty(PropertyName = "mask")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Mask { get; set; }
    }
}
