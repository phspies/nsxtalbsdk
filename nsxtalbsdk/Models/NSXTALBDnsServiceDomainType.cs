using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsServiceDomainType
    {
        /// <summary>
        /// Service domain string used for FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DomainName { get; set; }
        /// <summary>
        /// [DEPRECATED] Useless fieldPlease refer to DnsServiceApplicationProfile's num_dns_ip for default valuePlease refer to
        /// VsVip's dns_info num_records_in_response for user config valueSpecifies the number of A recordsreturned by Avi DNS
        /// Service. Field deprecated in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "num_dns_ip")]
        public int? NumDnsIp { get; set; }
        /// <summary>
        /// Third-party Authoritative domain requests are delegated toDNS VirtualService's pool of nameservers.
        /// </summary>
        [JsonProperty(PropertyName = "pass_through")]
        public bool? PassThrough { get; set; }
        /// <summary>
        /// TTL value for DNS records. Allowed values are 1-604800. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "record_ttl")]
        public int? RecordTtl { get; set; }
    }
}
