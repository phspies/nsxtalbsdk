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
    public class NSXTALBMatchTargetType 
    {
        public NSXTALBMatchTargetType()
        {
        }
        /// <summary>
        /// Configure the bot classification result. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "bot_detection_result")]
        public NSXTALBBotDetectionMatchType BotDetectionResult { get; set; }
        /// <summary>
        /// Configure client ip addresses.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Configure HTTP cookie(s).
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        public NSXTALBCookieMatchType Cookie { get; set; }
        /// <summary>
        /// Configure the geo information. Field introduced in 21.1.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "geo_matches")]
        public IList<NSXTALBGeoMatchType> GeoMatches { get; set; }
        /// <summary>
        /// Configure HTTP header(s). All configured headers must match.
        /// </summary>
        [JsonProperty(PropertyName = "hdrs")]
        public IList<NSXTALBHdrMatchType> Hdrs { get; set; }
        /// <summary>
        /// Configure the host header.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// Configure IP reputation. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_type")]
        public NSXTALBIPReputationTypeMatchType IpReputationType { get; set; }
        /// <summary>
        /// Configure HTTP methods.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public NSXTALBMethodMatchType Method { get; set; }
        /// <summary>
        /// Configure request paths.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// Configure the type of HTTP protocol.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// Configure request query.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public NSXTALBQueryMatchType Query { get; set; }
        /// <summary>
        /// Configure source ip addresses. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        public NSXTALBIpAddrMatchType SourceIp { get; set; }
        /// <summary>
        /// Configure versions of the HTTP protocol.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public NSXTALBHTTPVersionMatchType Version { get; set; }
        /// <summary>
        /// Configure virtual service ports.
        /// </summary>
        [JsonProperty(PropertyName = "vs_port")]
        public NSXTALBPortMatchType VsPort { get; set; }
    }
}
