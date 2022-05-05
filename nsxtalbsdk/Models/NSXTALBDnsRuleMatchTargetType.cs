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
    public class NSXTALBDnsRuleMatchTargetType 
    {
        /// <summary>
        /// IP addresses to match against client IP. From 17.1.6 release onwards, IP addresses needs to be configured in the
        /// client_ip_address field of this message. Field deprecated in 17.1.6,17.2.2. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// IP addresses to match against client IP or the EDNS client subnet IP. Field introduced in 17.1.6,17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip_address")]
        public NSXTALBDnsClientIpMatchType ClientIpAddress { get; set; }
        /// <summary>
        /// Port number to match against client port number. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_port_numbers")]
        public NSXTALBDnsClientPortMatchType ClientPortNumbers { get; set; }
        /// <summary>
        /// Geographical location attribute to match against that of the client IP. Field introduced in 17.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "geo_location")]
        public NSXTALBDnsGeoLocationMatchType GeoLocation { get; set; }
        /// <summary>
        /// DNS transport protocol match. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBDnsTransportProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// Domain names to match against query name. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "query_name")]
        public NSXTALBDnsQueryNameMatchType QueryName { get; set; }
        /// <summary>
        /// DNS query types to match against request query type. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "query_type")]
        public NSXTALBDnsQueryTypeMatchType QueryType { get; set; }
    }
}
