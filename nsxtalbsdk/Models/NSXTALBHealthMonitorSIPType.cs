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
    public class NSXTALBHealthMonitorSIPType 
    {
        /// <summary>
        /// Specify the transport protocol TCP or UDP, to be used for SIP health monitor. The default transport is UDP. Enum options
        /// - SIP_UDP_PROTO, SIP_TCP_PROTO. Field introduced in 17.2.14, 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_monitor_transport")]
        public string? SipMonitorTransport { get; set; }
        /// <summary>
        /// Specify the SIP request to be sent to the server. By default, SIP OPTIONS request will be sent. Enum options -
        /// SIP_OPTIONS. Field introduced in 17.2.8, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_request_code")]
        public string? SipRequestCode { get; set; }
        /// <summary>
        /// Match for a keyword in the first 2KB of the server header and body response. By default, it matches for SIP/2.0. Field
        /// introduced in 17.2.8, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_response")]
        public string? SipResponse { get; set; }
    }
}
