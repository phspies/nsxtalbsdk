using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbSiteDnsVsType 
    {
        /// <summary>
        /// This field identifies the DNS VS uuid for this site. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "dns_vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DnsVsUuid { get; set; }
        /// <summary>
        /// This field identifies the subdomains that are hosted on the DNS VS. GslbService(s) whose FQDNs map to one of the
        /// subdomains will be hosted on this DNS VS. If no subdomains are configured, then the default behavior is to host all the
        /// GslbServices on this DNS VS. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
    }
}
