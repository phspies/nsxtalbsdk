using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsRrSetType
    {
        /// <summary>
        /// Canonical name in CNAME record. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public NSXTALBDnsCnameRdataType Cname { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Fqdn { get; set; }
        /// <summary>
        /// IPv6 address in AAAA record. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_addresses")]
        public IList<NSXTALBDnsAAAARdataType> Ip6Addresses { get; set; }
        /// <summary>
        /// IP address in A record. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<NSXTALBDnsARdataType> IpAddresses { get; set; }
        /// <summary>
        /// Name Server information in NS record. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "nses")]
        public IList<NSXTALBDnsNsRdataType> Nses { get; set; }
        /// <summary>
        /// Time To Live for this DNS record. Allowed values are 0-2147483647. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Ttl { get; set; }
        /// <summary>
        /// DNS record type. Enum options - DNS_RECORD_OTHER, DNS_RECORD_A, DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA,
        /// DNS_RECORD_PTR, DNS_RECORD_HINFO, DNS_RECORD_MX, DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY, DNS_RECORD_AAAA,
        /// DNS_RECORD_SRV, DNS_RECORD_OPT, DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
