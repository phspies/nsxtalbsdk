using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsClientIpMatchType
    {
        /// <summary>
        /// IP addresses to match against client IP. Field introduced in 17.1.6,17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Use the IP address from the EDNS client subnet option, if available, as the source IP address of the client. It should
        /// be noted that the edns subnet IP may not be a /32 IP address. Field introduced in 17.1.6,17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "use_edns_client_subnet_ip")]
        public bool? UseEdnsClientSubnetIp { get; set; }
    }
}
