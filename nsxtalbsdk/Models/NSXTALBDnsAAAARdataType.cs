using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsAAAARdataType
    {
        /// <summary>
        /// IPv6 address for FQDN. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip6Address { get; set; }
    }
}
