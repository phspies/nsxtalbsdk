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
    public class NSXTALBCaptureFiltersType 
    {
        public NSXTALBCaptureFiltersType()
        {
        }
        /// <summary>
        /// Per packet IP filter. Matches with source and destination address. Curently not applicable for DebugServiceEngine. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "capture_ip")]
        public NSXTALBDebugIpAddrType CaptureIp { get; set; }
        /// <summary>
        /// Capture filter for SE IPC. Not applicable for Debug Virtual Service. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "capture_ipc")]
        public NSXTALBCaptureIPCType CaptureIpc { get; set; }
        /// <summary>
        /// Destination Port range filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "dst_port_end")]
        public int? DstPortEnd { get; set; }
        /// <summary>
        /// Destination Port range filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "dst_port_start")]
        public int? DstPortStart { get; set; }
        /// <summary>
        /// Ethernet Proto filter. Enum options - ETH_TYPE_IPV4. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "eth_proto")]
        public string? EthProto { get; set; }
        /// <summary>
        /// IP Proto filter. Support for TCP only for now. Enum options - IP_TYPE_TCP. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "ip_proto")]
        public string? IpProto { get; set; }
        /// <summary>
        /// Source Port filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        public int? SrcPort { get; set; }
        /// <summary>
        /// Source Port range end filter. If specified, the source port filter will be a range. The filter range will be between
        /// src_port and src_port_range_end. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "src_port_range_end")]
        public int? SrcPortRangeEnd { get; set; }
        /// <summary>
        /// TCP ACK flag filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_ack")]
        public bool? TcpAck { get; set; }
        /// <summary>
        /// TCP FIN flag filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_fin")]
        public bool? TcpFin { get; set; }
        /// <summary>
        /// TCP PUSH flag filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_push")]
        public bool? TcpPush { get; set; }
        /// <summary>
        /// TCP SYN flag filter. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_syn")]
        public bool? TcpSyn { get; set; }
    }
}
