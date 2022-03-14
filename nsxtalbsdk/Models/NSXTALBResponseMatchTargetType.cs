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
    public class NSXTALBResponseMatchTargetType 
    {
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
        /// Configure HTTP headers.
        /// </summary>
        [JsonProperty(PropertyName = "hdrs")]
        public IList<NSXTALBHdrMatchType> Hdrs { get; set; }
        /// <summary>
        /// Configure the host header.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// Configure the location header.
        /// </summary>
        [JsonProperty(PropertyName = "loc_hdr")]
        public NSXTALBLocationHdrMatchType LocHdr { get; set; }
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
        /// Configure the HTTP headers in response.
        /// </summary>
        [JsonProperty(PropertyName = "rsp_hdrs")]
        public IList<NSXTALBHdrMatchType> RspHdrs { get; set; }
        /// <summary>
        /// Configure source ip addresses. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        public NSXTALBIpAddrMatchType SourceIp { get; set; }
        /// <summary>
        /// Configure the HTTP status code(s).
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public NSXTALBHTTPStatusMatchType Status { get; set; }
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
