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
    public class NSXTALBDnsZoneType 
    {
        /// <summary>
        /// Email address of the administrator responsible for this zone. This field is used in SOA records as rname (RFC 1035). If
        /// not configured, it is inherited from the DNS service profile. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "admin_email")]
        public string? AdminEmail { get; set; }
        /// <summary>
        /// Domain name authoritatively serviced by this Virtual Service. Queries for FQDNs that are sub domains of this domain and
        /// do not have any DNS record in Avi are dropped or NXDomain response sent. For domains which are present, SOA parameters
        /// are sent in answer section of response if query type is SOA. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string DomainName { get; set; }
        /// <summary>
        /// The primary name server for this zone. This field is used in SOA records as mname (RFC 1035). If not configured, it is
        /// inherited from the DNS service profile. If even that is not configured, the domain name is used instead. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "name_server")]
        public string? NameServer { get; set; }
    }
}
