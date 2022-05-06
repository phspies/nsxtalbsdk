using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDNSConfigType
    {
        /// <summary>
        /// GSLB subdomain used for GSLB service FQDN match and placement. .
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DomainName { get; set; }
    }
}
