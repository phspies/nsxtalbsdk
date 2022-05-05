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
    public class NSXTALBConnErrorInfoType 
    {
        /// <summary>
        /// Number of num_syn_retransmit.
        /// </summary>
        [JsonProperty(PropertyName = "num_syn_retransmit")]
        public int? NumSynRetransmit { get; set; }
        /// <summary>
        /// Number of num_window_shrink.
        /// </summary>
        [JsonProperty(PropertyName = "num_window_shrink")]
        public int? NumWindowShrink { get; set; }
        /// <summary>
        /// Number of out_of_orders.
        /// </summary>
        [JsonProperty(PropertyName = "out_of_orders")]
        public int? OutOfOrders { get; set; }
        /// <summary>
        /// Number of retransmits.
        /// </summary>
        [JsonProperty(PropertyName = "retransmits")]
        public int? Retransmits { get; set; }
        /// <summary>
        /// Number of rx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "rx_pkts")]
        public long? RxPkts { get; set; }
        /// <summary>
        /// Number of server_num_window_shrink.
        /// </summary>
        [JsonProperty(PropertyName = "server_num_window_shrink")]
        public int? ServerNumWindowShrink { get; set; }
        /// <summary>
        /// Number of server_out_of_orders.
        /// </summary>
        [JsonProperty(PropertyName = "server_out_of_orders")]
        public int? ServerOutOfOrders { get; set; }
        /// <summary>
        /// Number of server_retransmits.
        /// </summary>
        [JsonProperty(PropertyName = "server_retransmits")]
        public int? ServerRetransmits { get; set; }
        /// <summary>
        /// Number of server_rx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "server_rx_pkts")]
        public long? ServerRxPkts { get; set; }
        /// <summary>
        /// Number of server_timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "server_timeouts")]
        public int? ServerTimeouts { get; set; }
        /// <summary>
        /// Number of server_tx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "server_tx_pkts")]
        public long? ServerTxPkts { get; set; }
        /// <summary>
        /// Number of server_zero_window_size_events.
        /// </summary>
        [JsonProperty(PropertyName = "server_zero_window_size_events")]
        public long? ServerZeroWindowSizeEvents { get; set; }
        /// <summary>
        /// Number of timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "timeouts")]
        public int? Timeouts { get; set; }
        /// <summary>
        /// Number of tx_pkts.
        /// </summary>
        [JsonProperty(PropertyName = "tx_pkts")]
        public long? TxPkts { get; set; }
        /// <summary>
        /// Number of zero_window_size_events.
        /// </summary>
        [JsonProperty(PropertyName = "zero_window_size_events")]
        public long? ZeroWindowSizeEvents { get; set; }
    }
}
