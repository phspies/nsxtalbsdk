using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsARdataType
    {
        /// <summary>
        /// IP address for FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddress { get; set; }
    }
}
