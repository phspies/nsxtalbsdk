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
    public class NSXTALBAuthenticationMatchType 
    {
        public NSXTALBAuthenticationMatchType()
        {
        }
        /// <summary>
        /// Configure client ip addresses. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Configure the host header. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// Configure request paths. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
    }
}
