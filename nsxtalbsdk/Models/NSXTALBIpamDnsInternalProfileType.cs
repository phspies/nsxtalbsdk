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
    public class NSXTALBIpamDnsInternalProfileType 
    {
        /// <summary>
        /// List of service domains.
        /// </summary>
        [JsonProperty(PropertyName = "dns_service_domain")]
        public IList<NSXTALBDnsServiceDomainType> DnsServiceDomain { get; set; }
        /// <summary>
        /// Avi VirtualService to be used for serving DNS records. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "dns_virtualservice_ref")]
        public string? DnsVirtualserviceRef { get; set; }
        /// <summary>
        /// Default TTL for all records, overridden by TTL value for each service domain configured in DnsServiceDomain. Allowed
        /// values are 1-604800. Unit is SEC. Allowed in Basic(Allowed values- 30) edition, Essentials(Allowed values- 30) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public int? Ttl { get; set; }
        /// <summary>
        /// Use usable_networks. It is a reference to an object of type Network. Field deprecated in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "usable_network_refs")]
        public IList<string> UsableNetworkRefs { get; set; }
        /// <summary>
        /// Usable networks for Virtual IP. If VirtualService does not specify a network and auto_allocate_ip is set, then the first
        /// available network from this list will be chosen for IP allocation. Field introduced in 20.1.3. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "usable_networks")]
        public IList<NSXTALBIpamUsableNetworkType> UsableNetworks { get; set; }
    }
}
