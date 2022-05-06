using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBTCPProxyProfileType
    {
        /// <summary>
        /// Controls the our congestion window to send, normally it's 1 mss, If this option is turned on, we use 10 msses.
        /// </summary>
        [JsonProperty(PropertyName = "aggressive_congestion_avoidance")]
        public bool? AggressiveCongestionAvoidance { get; set; }
        /// <summary>
        /// Controls whether the windows are static or supports autogrowth. Maximum that it can grow to is limited to 4MB. Field
        /// introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "auto_window_growth")]
        public bool? AutoWindowGrowth { get; set; }
        /// <summary>
        /// Dynamically pick the relevant parameters for connections. Allowed in Basic(Allowed values- true) edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "automatic")]
        public bool? Automatic { get; set; }
        /// <summary>
        /// Controls the congestion control algorithm we use. Enum options - CC_ALGO_NEW_RENO, CC_ALGO_CUBIC, CC_ALGO_HTCP.
        /// </summary>
        [JsonProperty(PropertyName = "cc_algo")]
        public string? CcAlgo { get; set; }
        /// <summary>
        /// Congestion window scaling factor after recovery. Allowed values are 0-8. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "congestion_recovery_scaling_factor")]
        public int? CongestionRecoveryScalingFactor { get; set; }
        /// <summary>
        /// The duration for keepalive probes or session idle timeout. Max value is 3600 seconds, min is 5.  Set to 0 to allow
        /// infinite idle time. Allowed values are 5-14400. Special values are 0 - infinite. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "idle_connection_timeout")]
        public int? IdleConnectionTimeout { get; set; }
        /// <summary>
        /// Controls the behavior of idle connections. Enum options - KEEP_ALIVE, CLOSE_IDLE.
        /// </summary>
        [JsonProperty(PropertyName = "idle_connection_type")]
        public string? IdleConnectionType { get; set; }
        /// <summary>
        /// A new SYN is accepted from the same 4-tuple even if there is already a connection in TIME_WAIT state.  This is
        /// equivalent of setting Time Wait Delay to 0.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_time_wait")]
        public bool? IgnoreTimeWait { get; set; }
        /// <summary>
        /// Controls the value of the Differentiated Services Code Point field inserted in the IP header.  This has two options  
        /// Set to a specific value, or Pass Through, which uses the incoming DSCP value. Allowed values are 0-63. Special values
        /// are MAX - Passthrough.
        /// </summary>
        [JsonProperty(PropertyName = "ip_dscp")]
        public int? IpDscp { get; set; }
        /// <summary>
        /// Controls whether to keep the connection alive with keepalive messages in the TCP half close state. The interval for
        /// sending keepalive messages is 30s. If a timeout is already configured in the network profile, this will not override it.
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "keepalive_in_halfclose_state")]
        public bool? KeepaliveInHalfcloseState { get; set; }
        /// <summary>
        /// The number of attempts at retransmit before closing the connection. Allowed values are 3-8.
        /// </summary>
        [JsonProperty(PropertyName = "max_retransmissions")]
        public int? MaxRetransmissions { get; set; }
        /// <summary>
        /// Maximum TCP segment size. Allowed values are 512-9000. Special values are 0 - Use Interface MTU. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "max_segment_size")]
        public int? MaxSegmentSize { get; set; }
        /// <summary>
        /// The maximum number of attempts at retransmitting a SYN packet before giving up. Allowed values are 3-8.
        /// </summary>
        [JsonProperty(PropertyName = "max_syn_retransmissions")]
        public int? MaxSynRetransmissions { get; set; }
        /// <summary>
        /// The minimum wait time (in millisec) to retransmit packet. Allowed values are 50-5000. Field introduced in 17.2.8. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "min_rexmt_timeout")]
        public int? MinRexmtTimeout { get; set; }
        /// <summary>
        /// Consolidates small data packets to send clients fewer but larger packets.  Adversely affects real time protocols such as
        /// telnet or SSH.
        /// </summary>
        [JsonProperty(PropertyName = "nagles_algorithm")]
        public bool? NaglesAlgorithm { get; set; }
        /// <summary>
        /// Maximum number of TCP segments that can be queued for reassembly. Configuring this to 0 disables the feature and
        /// provides unlimited queuing. Field introduced in 17.2.13, 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "reassembly_queue_size")]
        public int? ReassemblyQueueSize { get; set; }
        /// <summary>
        /// Size of the receive window. Allowed values are 2-65536. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "receive_window")]
        public int? ReceiveWindow { get; set; }
        /// <summary>
        /// Controls the number of duplicate acks required to trigger retransmission. Setting a higher value reduces retransmission
        /// caused by packet reordering. A larger value is recommended in public cloud environments where packet reordering is quite
        /// common. The default value is 8 in public cloud platforms (AWS, Azure, GCP), and 3 in other environments. Allowed values
        /// are 1-100. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "reorder_threshold")]
        public int? ReorderThreshold { get; set; }
        /// <summary>
        /// Congestion window scaling factor during slow start. Allowed values are 0-8. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "slow_start_scaling_factor")]
        public int? SlowStartScalingFactor { get; set; }
        /// <summary>
        /// The time (in millisec) to wait before closing a connection in the TIME_WAIT state. Allowed values are 500-2000. Special
        /// values are 0 - immediate. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "time_wait_delay")]
        public int? TimeWaitDelay { get; set; }
        /// <summary>
        /// Use the interface MTU to calculate the TCP max segment size.
        /// </summary>
        [JsonProperty(PropertyName = "use_interface_mtu")]
        public bool? UseInterfaceMtu { get; set; }
    }
}
