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
    public class NSXTALBDnsResolverType 
    {
        public NSXTALBDnsResolverType()
        {
        }
        /// <summary>
        /// If configured, this value used for refreshing the DNS entries.Overrides both received_ttl and min_ttl. The entries are
        /// refreshed only on fixed_ttleven when received_ttl is less than fixed_ttl. Allowed values are 5-2147483647. Field
        /// introduced in 20.1.5. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "fixed_ttl")]
        public int? FixedTtl { get; set; }
        /// <summary>
        /// If configured, the min_ttl overrides the ttl from responses when ttl < min_ttl,effectively ttl = max(recieved_ttl,
        /// min_ttl). Allowed values are 5-2147483647. Field introduced in 20.1.5. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "min_ttl")]
        public int? MinTtl { get; set; }
        /// <summary>
        /// Name server IPv4 addresses. Field introduced in 20.1.5. Minimum of 1 items required. Maximum of 10 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "nameserver_ips")]
        public IList<NSXTALBIpAddrType> NameserverIps { get; set; }
        /// <summary>
        /// Unique name for resolver config. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "resolver_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResolverName { get; set; }
        /// <summary>
        /// If enabled, DNS resolution is performed via management network. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "use_mgmt")]
        public bool? UseMgmt { get; set; }
    }
}
