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
    public class NSXTALBL4RuleMatchTargetType 
    {
        /// <summary>
        /// IP addresses to match against client IP. Field introduced in 17.2.7. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Port number to match against Virtual Service listner port. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public NSXTALBL4RulePortMatchType Port { get; set; }
        /// <summary>
        /// TCP/UDP/ICMP protocol to match against transport protocol. Field introduced in 17.2.7. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBL4RuleProtocolMatchType Protocol { get; set; }
    }
}
