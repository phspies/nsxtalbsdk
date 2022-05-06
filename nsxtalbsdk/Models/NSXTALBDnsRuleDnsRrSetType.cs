using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsRuleDnsRrSetType
    {
        /// <summary>
        /// DNS resource record set - (records in the resource record set share the DNS domain name, type, and class). Field
        /// introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "resource_record_set")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBDnsRrSetType ResourceRecordSet { get; set; }
        /// <summary>
        /// DNS message section for the resource record set. Enum options - DNS_MESSAGE_SECTION_QUESTION,
        /// DNS_MESSAGE_SECTION_ANSWER, DNS_MESSAGE_SECTION_AUTHORITY, DNS_MESSAGE_SECTION_ADDITIONAL. Field introduced in 17.2.12,
        /// 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "section")]
        public string? Section { get; set; }
    }
}
