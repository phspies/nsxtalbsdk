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
    public class NSXTALBBotMappingRuleMatchTargetType 
    {
        /// <summary>
        /// How to match the BotClientClass. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "class_matcher")]
        public NSXTALBBotClassMatcherType ClassMatcher { get; set; }
        /// <summary>
        /// Configure client ip addresses. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// The component for which this mapping is used. Enum options - BOT_DECIDER_CONSOLIDATION, BOT_DECIDER_USER_AGENT,
        /// BOT_DECIDER_IP_REPUTATION, BOT_DECIDER_IP_NETWORK_LOCATION. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "component_matcher")]
        public string? ComponentMatcher { get; set; }
        /// <summary>
        /// Configure HTTP header(s). All configured headers must match. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "hdrs")]
        public IList<NSXTALBHdrMatchType> Hdrs { get; set; }
        /// <summary>
        /// Configure the host header. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// The list of bot identifier names and how they're matched. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "identifier_matcher")]
        public NSXTALBStringMatchType IdentifierMatcher { get; set; }
        /// <summary>
        /// Configure HTTP methods. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public NSXTALBMethodMatchType Method { get; set; }
        /// <summary>
        /// Configure request paths. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
        /// <summary>
        /// How to match the BotClientType. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type_matcher")]
        public NSXTALBBotTypeMatcherType TypeMatcher { get; set; }
    }
}
