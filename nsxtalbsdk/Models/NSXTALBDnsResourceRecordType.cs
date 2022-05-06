using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsResourceRecordType
    {
        /// <summary>
        /// IPv6 address of the requested FQDN. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "addr6_ip_str")]
        public string? Addr6IpStr { get; set; }
        /// <summary>
        /// IPv4 address of the requested FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "addr_ip")]
        public int? AddrIp { get; set; }
        /// <summary>
        /// Canonical (real) name of the requested FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public string? Cname { get; set; }
        /// <summary>
        /// Class of the data in the resource record.
        /// </summary>
        [JsonProperty(PropertyName = "dclass")]
        public int? Dclass { get; set; }
        /// <summary>
        /// Geo Location of Member. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public NSXTALBGeoLocationType Location { get; set; }
        /// <summary>
        /// Fully qualified domain name of a mail server in the MX record. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mail_server")]
        public string? MailServer { get; set; }
        /// <summary>
        /// Domain name of the resource record.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Domain name of the name server that is authoritative for the requested FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "nsname")]
        public string? Nsname { get; set; }
        /// <summary>
        /// Service port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// The priority field identifies which mail server should be preferred. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }
        /// <summary>
        /// Site controller cluster name - applicable only for Avi VS GSLB member.
        /// </summary>
        [JsonProperty(PropertyName = "site_name")]
        public string? SiteName { get; set; }
        /// <summary>
        /// Text resource record. Field introduced in 18.2.9, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "text_rdata")]
        public string? TextRdata { get; set; }
        /// <summary>
        /// Number of seconds the resource record can be cached.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Ttl { get; set; }
        /// <summary>
        /// Type of resource record. Enum options - DNS_RECORD_OTHER, DNS_RECORD_A, DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA,
        /// DNS_RECORD_PTR, DNS_RECORD_HINFO, DNS_RECORD_MX, DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY, DNS_RECORD_AAAA,
        /// DNS_RECORD_SRV, DNS_RECORD_OPT, DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Virtual Service name - applicable only for Avi VS GSLB member.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
    }
}
