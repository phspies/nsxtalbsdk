using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsTransportProtocolMatchType
    {
        /// <summary>
        /// Criterion to use for matching the DNS transport protocol. Enum options - IS_IN, IS_NOT_IN. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Protocol to match against transport protocol used by DNS query. Enum options - DNS_OVER_UDP, DNS_OVER_TCP. Field
        /// introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
    }
}
