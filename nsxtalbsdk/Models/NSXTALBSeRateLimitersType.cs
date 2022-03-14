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
    public class NSXTALBSeRateLimitersType 
    {
        public NSXTALBSeRateLimitersType()
        {
        }
        /// <summary>
        /// Rate limiter for ARP packets in pps.
        /// </summary>
        [JsonProperty(PropertyName = "arp_rl")]
        public int? ArpRl { get; set; }
        /// <summary>
        /// Default Rate limiter in pps.
        /// </summary>
        [JsonProperty(PropertyName = "default_rl")]
        public int? DefaultRl { get; set; }
        /// <summary>
        /// Rate limiter for number of flow probes in pps.
        /// </summary>
        [JsonProperty(PropertyName = "flow_probe_rl")]
        public int? FlowProbeRl { get; set; }
        /// <summary>
        /// Rate limiter for ICMP requests in pps.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_rl")]
        public int? IcmpRl { get; set; }
        /// <summary>
        /// Rate limiter for ICMP response in pps.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_rsp_rl")]
        public int? IcmpRspRl { get; set; }
        /// <summary>
        /// Rate limiter for number RST pkts sent in pps.
        /// </summary>
        [JsonProperty(PropertyName = "rst_rl")]
        public int? RstRl { get; set; }
    }
}
