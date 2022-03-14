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
    public class NSXTALBDynamicDnsRecordType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Specifies the algorithm to pick the IP address(es) to be returned,when multiple entries are configured. This does not
        /// apply if num_records_in_response is 0. Default is round-robin. Enum options - DNS_RECORD_RESPONSE_ROUND_ROBIN,
        /// DNS_RECORD_RESPONSE_CONSISTENT_HASH. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        public string? Algorithm { get; set; }
        /// <summary>
        /// Canonical name in CNAME record. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cname")]
        public NSXTALBDnsCnameRdataType Cname { get; set; }
        /// <summary>
        /// Configured FQDNs are delegated domains (i.e. they represent a zone cut). Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "delegated")]
        public bool? Delegated { get; set; }
        /// <summary>
        /// Details of DNS record. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// UUID of the DNS VS. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "dns_vs_uuid")]
        public string? DnsVsUuid { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// IPv6 address in AAAA record. Field introduced in 20.1.3. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        public IList<NSXTALBDnsAAAARdataType> Ip6Address { get; set; }
        /// <summary>
        /// IP address in A record. Field introduced in 20.1.3. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public IList<NSXTALBDnsARdataType> IpAddress { get; set; }
        /// <summary>
        /// Internal metadata for the DNS record. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
        /// <summary>
        /// MX record. Field introduced in 20.1.3. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "mx_records")]
        public IList<NSXTALBDnsMxRdataType> MxRecords { get; set; }
        /// <summary>
        /// DynamicDnsRecord name, needed for a top level uuid protobuf, for display in shell. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Name Server information in NS record. Field introduced in 20.1.3. Maximum of 13 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ns")]
        public IList<NSXTALBDnsNsRdataType> Ns { get; set; }
        /// <summary>
        /// Specifies the number of records returned by the DNS service.Enter 0 to return all records. Default is 0. Allowed values
        /// are 0-20. Special values are 0- Return all records. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "num_records_in_response")]
        public int? NumRecordsInResponse { get; set; }
        /// <summary>
        /// Service locator info in SRV record. Field introduced in 20.1.3. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "service_locators")]
        public IList<NSXTALBDnsSrvRdataType> ServiceLocators { get; set; }
        /// <summary>
        /// tenant_uuid from Dns VS's tenant_uuid. It is a reference to an object of type Tenant. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Time To Live for this DNS record. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public int? Ttl { get; set; }
        /// <summary>
        /// Text record. Field introduced in 20.1.3. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "txt_records")]
        public IList<NSXTALBDnsTxtRdataType> TxtRecords { get; set; }
        /// <summary>
        /// DNS record type. Enum options - DNS_RECORD_OTHER, DNS_RECORD_A, DNS_RECORD_NS, DNS_RECORD_CNAME, DNS_RECORD_SOA,
        /// DNS_RECORD_PTR, DNS_RECORD_HINFO, DNS_RECORD_MX, DNS_RECORD_TXT, DNS_RECORD_RP, DNS_RECORD_DNSKEY, DNS_RECORD_AAAA,
        /// DNS_RECORD_SRV, DNS_RECORD_OPT, DNS_RECORD_RRSIG, DNS_RECORD_AXFR, DNS_RECORD_ANY. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of the dns record. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Enable wild-card match of fqdn  if an exact match is not found in the DNS table, the longest match is chosen by
        /// wild-carding the fqdn in the DNS request. Default is false. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "wildcard_match")]
        public bool? WildcardMatch { get; set; }
    }
}
