using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthMonitorLdapType
    {
        /// <summary>
        /// Attributes which will be retrieved. commas can be used to delimit more than one attributes (example- cn,address,email).
        /// Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public string? Attributes { get; set; }
        /// <summary>
        /// DN(Distinguished Name) of a directory entry. which will be starting point of the search. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "base_dn")]
        [System.ComponentModel.DataAnnotations.Required]
        public string BaseDn { get; set; }
        /// <summary>
        /// Filter to search entries in specified scope. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string? Filter { get; set; }
        /// <summary>
        /// Search scope which can be base, one, sub. Enum options - LDAP_BASE_MODE, LDAP_ONE_MODE, LDAP_SUB_MODE. Field introduced
        /// in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// SSL attributes for LDAPS monitor. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}
