using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsRuleActionResponseType
    {
        /// <summary>
        /// DNS response is authoritative. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "authoritative")]
        public bool? Authoritative { get; set; }
        /// <summary>
        /// DNS response code. Enum options - DNS_RCODE_NOERROR, DNS_RCODE_FORMERR, DNS_RCODE_SERVFAIL, DNS_RCODE_NXDOMAIN,
        /// DNS_RCODE_NOTIMP, DNS_RCODE_REFUSED, DNS_RCODE_YXDOMAIN, DNS_RCODE_YXRRSET, DNS_RCODE_NXRRSET, DNS_RCODE_NOTAUTH,
        /// DNS_RCODE_NOTZONE. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rcode")]
        public string? Rcode { get; set; }
        /// <summary>
        /// DNS resource record sets - (resource record set share the DNS domain name, type, and class). Field introduced in
        /// 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "resource_record_sets")]
        public IList<NSXTALBDnsRuleDnsRrSetType> ResourceRecordSets { get; set; }
        /// <summary>
        /// DNS response is truncated. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "truncation")]
        public bool? Truncation { get; set; }
    }
}
