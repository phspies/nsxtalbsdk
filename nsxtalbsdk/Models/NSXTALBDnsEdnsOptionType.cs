using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsEdnsOptionType
    {
        /// <summary>
        /// Address family. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "addr_family")]
        public int? AddrFamily { get; set; }
        /// <summary>
        /// EDNS option code. Enum options - EDNS_OPTION_CODE_NSID, EDNS_OPTION_CODE_DNSSEC_DAU, EDNS_OPTION_CODE_DNSSEC_DHU,
        /// EDNS_OPTION_CODE_DNSSEC_N3U, EDNS_OPTION_CODE_CLIENT_SUBNET, EDNS_OPTION_CODE_EXPIRE, EDNS_OPTION_CODE_COOKIE,
        /// EDNS_OPTION_CODE_TCP_KEEPALIVE, EDNS_OPTION_CODE_PADDING, EDNS_OPTION_CODE_CHAIN. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Code { get; set; }
        /// <summary>
        /// Scope prefix length of address. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "scope_prefix_len")]
        public int? ScopePrefixLen { get; set; }
        /// <summary>
        /// Source prefix length of address. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "source_prefix_len")]
        public int? SourcePrefixLen { get; set; }
        /// <summary>
        /// IPv4 address of the client subnet. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_ip")]
        public int? SubnetIp { get; set; }
        /// <summary>
        /// IPv6 address of the client subnet. Field introduced in 18.2.12, 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_ip6")]
        public string? SubnetIp6 { get; set; }
    }
}
