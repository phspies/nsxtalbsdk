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
    public class NSXTALBDnsServiceApplicationProfileType 
    {
        /// <summary>
        /// Respond to AAAA queries with empty response when there are only IPV4 records.
        /// </summary>
        [JsonProperty(PropertyName = "aaaa_empty_response")]
        public bool? AaaaEmptyResponse { get; set; }
        /// <summary>
        /// Email address of the administrator responsible for this zone . This field is used in SOA records (rname) pertaining to
        /// all domain names specified as authoritative domain names. If not configured, the default value 'hostmaster' is used in
        /// SOA responses. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "admin_email")]
        public string? AdminEmail { get; set; }
        /// <summary>
        /// Domain names authoritatively serviced by this Virtual Service. These are configured as Ends-With semantics. Queries for
        /// FQDNs that are subdomains of this domain and do not have any DNS record in Avi are dropped or NXDomain response sent. .
        /// Field deprecated in 18.2.6. Field introduced in 17.1.6,17.2.2. Maximum of 100 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "authoritative_domain_names")]
        public IList<string> AuthoritativeDomainNames { get; set; }
        /// <summary>
        /// Enable DNS query/response over TCP. This enables analytics for pass-through queries as well. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dns_over_tcp_enabled")]
        public bool? DnsOverTcpEnabled { get; set; }
        /// <summary>
        /// DNS zones hosted on this Virtual Service. Field introduced in 18.2.6. Maximum of 100 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "dns_zones")]
        public IList<NSXTALBDnsZoneType> DnsZones { get; set; }
        /// <summary>
        /// Subdomain names serviced by this Virtual Service. These are configured as Ends-With semantics. Maximum of 100 items
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
        /// <summary>
        /// Enable stripping of EDNS client subnet (ecs) option towards client if DNS service inserts ecs option in the DNS query
        /// towards upstream servers. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "ecs_stripping_enabled")]
        public bool? EcsStrippingEnabled { get; set; }
        /// <summary>
        /// Enable DNS service to be aware of EDNS (Extension mechanism for DNS). EDNS extensions are parsed and shown in logs. For
        /// GSLB services, the EDNS client subnet option can be used to influence Load Balancing. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "edns")]
        public bool? Edns { get; set; }
        /// <summary>
        /// Specifies the IP address prefix length to use in the EDNS client subnet (ECS) option. When the incoming request does not
        /// have any ECS option and the prefix length is specified, an ECS option is inserted in the request passed to upstream
        /// server. If the incoming request already has an ECS option, the prefix length (and correspondingly the address) in the
        /// ECS option is updated, with the minimum of the prefix length present in the incoming and the configured prefix length,
        /// before passing the request to upstream server. Allowed values are 1-32. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "edns_client_subnet_prefix_len")]
        public int? EdnsClientSubnetPrefixLen { get; set; }
        /// <summary>
        /// Drop or respond to client when the DNS service encounters an error processing a client query. By default, such a request
        /// is dropped without any response, or passed through to a passthrough pool, if configured. When set to respond, an
        /// appropriate response is sent to client, e.g. NXDOMAIN response for non-existent records, empty NOERROR response for
        /// unsupported queries, etc. Enum options - DNS_ERROR_RESPONSE_ERROR, DNS_ERROR_RESPONSE_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "error_response")]
        public string? ErrorResponse { get; set; }
        /// <summary>
        /// The <domain-name>  of the name server that was the original or primary source of data for this zone. This field is used
        /// in SOA records (mname) pertaining to all domain names specified as authoritative domain names. If not configured, domain
        /// name is used as name server in SOA response. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "name_server")]
        public string? NameServer { get; set; }
        /// <summary>
        /// Specifies the TTL value (in seconds) for SOA (Start of Authority) (corresponding to a authoritative domain owned by this
        /// DNS Virtual Service) record's minimum TTL served by the DNS Virtual Service. Allowed values are 0-86400. Field
        /// introduced in 17.2.4. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "negative_caching_ttl")]
        public int? NegativeCachingTtl { get; set; }
        /// <summary>
        /// Specifies the number of IP addresses returned by the DNS Service. Enter 0 to return all IP addresses. Allowed values are
        /// 1-20. Special values are 0- Return all IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "num_dns_ip")]
        public int? NumDnsIp { get; set; }
        /// <summary>
        /// Specifies the TTL value (in seconds) for records served by DNS Service. Allowed values are 0-86400. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public int? Ttl { get; set; }
    }
}
