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
    public class NSXTALBNetworkProfileUnionType 
    {
        /// <summary>
        /// Placeholder for description of property tcp_fast_path_profile of obj type NetworkProfileUnion field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "tcp_fast_path_profile")]
        public NSXTALBTCPFastPathProfileType TcpFastPathProfile { get; set; }
        /// <summary>
        /// Placeholder for description of property tcp_proxy_profile of obj type NetworkProfileUnion field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "tcp_proxy_profile")]
        public NSXTALBTCPProxyProfileType TcpProxyProfile { get; set; }
        /// <summary>
        /// Configure one of either proxy or fast path profiles. Enum options - PROTOCOL_TYPE_TCP_PROXY,
        /// PROTOCOL_TYPE_TCP_FAST_PATH, PROTOCOL_TYPE_UDP_FAST_PATH, PROTOCOL_TYPE_UDP_PROXY. Allowed in Basic(Allowed values-
        /// PROTOCOL_TYPE_TCP_PROXY,PROTOCOL_TYPE_TCP_FAST_PATH,PROTOCOL_TYPE_UDP_FAST_PATH) edition, Essentials(Allowed values-
        /// PROTOCOL_TYPE_TCP_FAST_PATH,PROTOCOL_TYPE_UDP_FAST_PATH) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Placeholder for description of property udp_fast_path_profile of obj type NetworkProfileUnion field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "udp_fast_path_profile")]
        public NSXTALBUDPFastPathProfileType UdpFastPathProfile { get; set; }
        /// <summary>
        /// Configure UDP Proxy network profile. Field introduced in 17.2.8, 18.1.3, 18.2.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "udp_proxy_profile")]
        public NSXTALBUDPProxyProfileType UdpProxyProfile { get; set; }
    }
}
