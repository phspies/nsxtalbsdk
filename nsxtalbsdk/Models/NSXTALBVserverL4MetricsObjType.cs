using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVserverL4MetricsObjType
    {
        /// <summary>
        /// apdex measuring quality of network connections to servers.
        /// </summary>
        [JsonProperty(PropertyName = "apdexc")]
        public double? Apdexc { get; set; }
        /// <summary>
        /// apdex measuring network connection quality based on RTT.
        /// </summary>
        [JsonProperty(PropertyName = "apdexrtt")]
        public double? Apdexrtt { get; set; }
        /// <summary>
        /// Number of Application DDOS attacks occurring.
        /// </summary>
        [JsonProperty(PropertyName = "avg_application_dos_attacks")]
        public double? AvgApplicationDosAttacks { get; set; }
        /// <summary>
        /// Average transmit and receive network bandwidth between client and virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "avg_bandwidth")]
        public double? AvgBandwidth { get; set; }
        /// <summary>
        /// Averaged rate bytes dropped per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_bytes_policy_drops")]
        public double? AvgBytesPolicyDrops { get; set; }
        /// <summary>
        /// Rate of total connections per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_complete_conns")]
        public double? AvgCompleteConns { get; set; }
        /// <summary>
        /// Rate of dropped connections per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_connections_dropped")]
        public double? AvgConnectionsDropped { get; set; }
        /// <summary>
        /// DoS attack  Rate of HTTP App Errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_app_error")]
        public double? AvgDosAppError { get; set; }
        /// <summary>
        /// Number DDOS attacks occurring.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_attacks")]
        public double? AvgDosAttacks { get; set; }
        /// <summary>
        /// DoS attack  Rate of Bad Rst Floods.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_bad_rst_flood")]
        public double? AvgDosBadRstFlood { get; set; }
        /// <summary>
        /// Average transmit and receive network bandwidth between client and virtual service related to DDoS attack.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_bandwidth")]
        public double? AvgDosBandwidth { get; set; }
        /// <summary>
        /// Number of connections considered as DoS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_conn")]
        public double? AvgDosConn { get; set; }
        /// <summary>
        /// DoS attack  Connections dropped due to IP rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_conn_ip_rl_drop")]
        public double? AvgDosConnIpRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Connections dropped due to VS rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_conn_rl_drop")]
        public double? AvgDosConnRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Rate of Fake Sessions.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_fake_session")]
        public double? AvgDosFakeSession { get; set; }
        /// <summary>
        /// DoS attack  Rate of HTTP Aborts.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_http_abort")]
        public double? AvgDosHttpAbort { get; set; }
        /// <summary>
        /// DoS attack  Rate of HTTP Errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_http_error")]
        public double? AvgDosHttpError { get; set; }
        /// <summary>
        /// DoS attack  Rate of HTTP Timeouts.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_http_timeout")]
        public double? AvgDosHttpTimeout { get; set; }
        /// <summary>
        /// DoS attack  Rate of Malformed Packet Floods.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_malformed_flood")]
        public double? AvgDosMalformedFlood { get; set; }
        /// <summary>
        /// DoS attack  Non SYN packet flood.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_non_syn_flood")]
        public double? AvgDosNonSynFlood { get; set; }
        /// <summary>
        /// Number of request considered as DoS.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req")]
        public double? AvgDosReq { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to Cookie rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_cookie_rl_drop")]
        public double? AvgDosReqCookieRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to Custom rate limit. Field introduced in 17.2.13,18.1.3,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_custom_rl_drop")]
        public double? AvgDosReqCustomRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to Header rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_hdr_rl_drop")]
        public double? AvgDosReqHdrRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to IP rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_ip_rl_drop")]
        public double? AvgDosReqIpRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to IP rate limit for bad requests.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_ip_rl_drop_bad")]
        public double? AvgDosReqIpRlDropBad { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to bad IP rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_ip_scan_bad_rl_drop")]
        public double? AvgDosReqIpScanBadRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to unknown IP rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_ip_scan_unknown_rl_drop")]
        public double? AvgDosReqIpScanUnknownRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to IP+URL rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_ip_uri_rl_drop")]
        public double? AvgDosReqIpUriRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to IP+URL rate limit for bad requests.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_ip_uri_rl_drop_bad")]
        public double? AvgDosReqIpUriRlDropBad { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to VS rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_rl_drop")]
        public double? AvgDosReqRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to URL rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_uri_rl_drop")]
        public double? AvgDosReqUriRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to URL rate limit for bad requests.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_uri_rl_drop_bad")]
        public double? AvgDosReqUriRlDropBad { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to bad URL rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_uri_scan_bad_rl_drop")]
        public double? AvgDosReqUriScanBadRlDrop { get; set; }
        /// <summary>
        /// DoS attack  Requests dropped due to unknown URL rate limit.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_req_uri_scan_unknown_rl_drop")]
        public double? AvgDosReqUriScanUnknownRlDrop { get; set; }
        /// <summary>
        /// Average rate of bytes received per second related to DDoS attack.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_rx_bytes")]
        public double? AvgDosRxBytes { get; set; }
        /// <summary>
        /// DoS attack  Slow Uri.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_slow_uri")]
        public double? AvgDosSlowUri { get; set; }
        /// <summary>
        /// DoS attack  Rate of Small Window Stresses.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_small_window_stress")]
        public double? AvgDosSmallWindowStress { get; set; }
        /// <summary>
        /// DoS attack  Rate of HTTP SSL Errors.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_ssl_error")]
        public double? AvgDosSslError { get; set; }
        /// <summary>
        /// DoS attack  Rate of Syn Floods.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_syn_flood")]
        public double? AvgDosSynFlood { get; set; }
        /// <summary>
        /// Total number of request used for L7 dos requests normalization.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_total_req")]
        public double? AvgDosTotalReq { get; set; }
        /// <summary>
        /// Average rate of bytes transmitted per second related to DDoS attack.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_tx_bytes")]
        public double? AvgDosTxBytes { get; set; }
        /// <summary>
        /// DoS attack  Rate of Zero Window Stresses.
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_zero_window_stress")]
        public double? AvgDosZeroWindowStress { get; set; }
        /// <summary>
        /// Rate of total errored connections per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_errored_connections")]
        public double? AvgErroredConnections { get; set; }
        /// <summary>
        /// Average rate of SYN DDoS attacks on Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "avg_half_open_conns")]
        public double? AvgHalfOpenConns { get; set; }
        /// <summary>
        /// Average L4 connection duration which does not include client RTT.
        /// </summary>
        [JsonProperty(PropertyName = "avg_l4_client_latency")]
        public double? AvgL4ClientLatency { get; set; }
        /// <summary>
        /// Rate of lossy connections per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_lossy_connections")]
        public double? AvgLossyConnections { get; set; }
        /// <summary>
        /// Averaged rate of lossy request per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_lossy_req")]
        public double? AvgLossyReq { get; set; }
        /// <summary>
        /// Number of Network DDOS attacks occurring.
        /// </summary>
        [JsonProperty(PropertyName = "avg_network_dos_attacks")]
        public double? AvgNetworkDosAttacks { get; set; }
        /// <summary>
        /// Averaged rate of new client connections per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_new_established_conns")]
        public double? AvgNewEstablishedConns { get; set; }
        /// <summary>
        /// Averaged rate of dropped packets per second due to policy.
        /// </summary>
        [JsonProperty(PropertyName = "avg_pkts_policy_drops")]
        public double? AvgPktsPolicyDrops { get; set; }
        /// <summary>
        /// Rate of total connections dropped due to VS policy per second. It includes drops due to rate limits, security policy
        /// drops, connection limits etc.
        /// </summary>
        [JsonProperty(PropertyName = "avg_policy_drops")]
        public double? AvgPolicyDrops { get; set; }
        /// <summary>
        /// Average rate of bytes received per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_rx_bytes")]
        public double? AvgRxBytes { get; set; }
        /// <summary>
        /// Average rate of received bytes dropped per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_rx_bytes_dropped")]
        public double? AvgRxBytesDropped { get; set; }
        /// <summary>
        /// Average rate of packets received per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_rx_pkts")]
        public double? AvgRxPkts { get; set; }
        /// <summary>
        /// Average rate of received packets dropped per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_rx_pkts_dropped")]
        public double? AvgRxPktsDropped { get; set; }
        /// <summary>
        /// Total syncs sent across all connections.
        /// </summary>
        [JsonProperty(PropertyName = "avg_syns")]
        public double? AvgSyns { get; set; }
        /// <summary>
        /// Averaged rate bytes dropped per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_total_connections")]
        public double? AvgTotalConnections { get; set; }
        /// <summary>
        /// Average network round trip time between client and virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "avg_total_rtt")]
        public double? AvgTotalRtt { get; set; }
        /// <summary>
        /// Average rate of bytes transmitted per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_tx_bytes")]
        public double? AvgTxBytes { get; set; }
        /// <summary>
        /// Average rate of packets transmitted per second.
        /// </summary>
        [JsonProperty(PropertyName = "avg_tx_pkts")]
        public double? AvgTxPkts { get; set; }
        /// <summary>
        /// Max number of SEs.
        /// </summary>
        [JsonProperty(PropertyName = "max_num_active_se")]
        public double? MaxNumActiveSe { get; set; }
        /// <summary>
        /// Max number of open connections.
        /// </summary>
        [JsonProperty(PropertyName = "max_open_conns")]
        public double? MaxOpenConns { get; set; }
        /// <summary>
        /// Total number of received bytes.
        /// </summary>
        [JsonProperty(PropertyName = "max_rx_bytes_absolute")]
        public double? MaxRxBytesAbsolute { get; set; }
        /// <summary>
        /// Total number of received frames.
        /// </summary>
        [JsonProperty(PropertyName = "max_rx_pkts_absolute")]
        public double? MaxRxPktsAbsolute { get; set; }
        /// <summary>
        /// Total number of transmitted bytes.
        /// </summary>
        [JsonProperty(PropertyName = "max_tx_bytes_absolute")]
        public double? MaxTxBytesAbsolute { get; set; }
        /// <summary>
        /// Total number of transmitted frames.
        /// </summary>
        [JsonProperty(PropertyName = "max_tx_pkts_absolute")]
        public double? MaxTxPktsAbsolute { get; set; }
        /// <summary>
        /// node_obj_id of VserverL4MetricsObj.
        /// </summary>
        [JsonProperty(PropertyName = "node_obj_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NodeObjId { get; set; }
        /// <summary>
        /// Fraction of L7 requests owing to DoS.
        /// </summary>
        [JsonProperty(PropertyName = "pct_application_dos_attacks")]
        public double? PctApplicationDosAttacks { get; set; }
        /// <summary>
        /// Percent of l4 connection dropped and lossy for virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "pct_connection_errors")]
        public double? PctConnectionErrors { get; set; }
        /// <summary>
        /// Fraction of L4 connections owing to DoS.
        /// </summary>
        [JsonProperty(PropertyName = "pct_connections_dos_attacks")]
        public double? PctConnectionsDosAttacks { get; set; }
        /// <summary>
        /// DoS bandwidth percentage.
        /// </summary>
        [JsonProperty(PropertyName = "pct_dos_bandwidth")]
        public double? PctDosBandwidth { get; set; }
        /// <summary>
        /// Percentage of received bytes as part of a DoS attack.
        /// </summary>
        [JsonProperty(PropertyName = "pct_dos_rx_bytes")]
        public double? PctDosRxBytes { get; set; }
        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "pct_network_dos_attacks")]
        public double? PctNetworkDosAttacks { get; set; }
        /// <summary>
        /// Fraction of packets owing to DoS.
        /// </summary>
        [JsonProperty(PropertyName = "pct_pkts_dos_attacks")]
        public double? PctPktsDosAttacks { get; set; }
        /// <summary>
        /// Fraction of L4 requests dropped owing to policy.
        /// </summary>
        [JsonProperty(PropertyName = "pct_policy_drops")]
        public double? PctPolicyDrops { get; set; }
        /// <summary>
        /// Total duration across all connections.
        /// </summary>
        [JsonProperty(PropertyName = "sum_conn_duration")]
        public double? SumConnDuration { get; set; }
        /// <summary>
        /// Total number of connection dropped due to vserver connection limit.
        /// </summary>
        [JsonProperty(PropertyName = "sum_connection_dropped_user_limit")]
        public double? SumConnectionDroppedUserLimit { get; set; }
        /// <summary>
        /// Total number of client network connections that were lossy or dropped.
        /// </summary>
        [JsonProperty(PropertyName = "sum_connection_errors")]
        public double? SumConnectionErrors { get; set; }
        /// <summary>
        /// Total connections dropped including failed.
        /// </summary>
        [JsonProperty(PropertyName = "sum_connections_dropped")]
        public double? SumConnectionsDropped { get; set; }
        /// <summary>
        /// Total duplicate ACK retransmits across all connections.
        /// </summary>
        [JsonProperty(PropertyName = "sum_dup_ack_retransmits")]
        public double? SumDupAckRetransmits { get; set; }
        /// <summary>
        /// Sum of end to end network RTT experienced by end clients. Higher value would increase response times experienced by
        /// clients.
        /// </summary>
        [JsonProperty(PropertyName = "sum_end_to_end_rtt")]
        public double? SumEndToEndRtt { get; set; }
        /// <summary>
        /// Total connections that have RTT values from 0 to RTT threshold.
        /// </summary>
        [JsonProperty(PropertyName = "sum_end_to_end_rtt_bucket1")]
        public double? SumEndToEndRttBucket1 { get; set; }
        /// <summary>
        /// Total connections that have RTT values RTT threshold and above.
        /// </summary>
        [JsonProperty(PropertyName = "sum_end_to_end_rtt_bucket2")]
        public double? SumEndToEndRttBucket2 { get; set; }
        /// <summary>
        /// Total number of finished connections.
        /// </summary>
        [JsonProperty(PropertyName = "sum_finished_conns")]
        public double? SumFinishedConns { get; set; }
        /// <summary>
        /// Total connections that were lossy due to high packet retransmissions.
        /// </summary>
        [JsonProperty(PropertyName = "sum_lossy_connections")]
        public double? SumLossyConnections { get; set; }
        /// <summary>
        /// Total requests that were lossy due to high packet retransmissions.
        /// </summary>
        [JsonProperty(PropertyName = "sum_lossy_req")]
        public double? SumLossyReq { get; set; }
        /// <summary>
        /// Total out of order packets across all connections.
        /// </summary>
        [JsonProperty(PropertyName = "sum_out_of_orders")]
        public double? SumOutOfOrders { get; set; }
        /// <summary>
        /// Total number of packets dropped due to vserver bandwidth limit.
        /// </summary>
        [JsonProperty(PropertyName = "sum_packet_dropped_user_bandwidth_limit")]
        public double? SumPacketDroppedUserBandwidthLimit { get; set; }
        /// <summary>
        /// Total number connections used for rtt.
        /// </summary>
        [JsonProperty(PropertyName = "sum_rtt_valid_connections")]
        public double? SumRttValidConnections { get; set; }
        /// <summary>
        /// Total SACK retransmits across all connections.
        /// </summary>
        [JsonProperty(PropertyName = "sum_sack_retransmits")]
        public double? SumSackRetransmits { get; set; }
        /// <summary>
        /// Total number of connections with server flow control condition.
        /// </summary>
        [JsonProperty(PropertyName = "sum_server_flow_control")]
        public double? SumServerFlowControl { get; set; }
        /// <summary>
        /// Total connection timeouts in the interval.
        /// </summary>
        [JsonProperty(PropertyName = "sum_timeout_retransmits")]
        public double? SumTimeoutRetransmits { get; set; }
        /// <summary>
        /// Total number of zero window size events across all connections.
        /// </summary>
        [JsonProperty(PropertyName = "sum_zero_window_size_events")]
        public double? SumZeroWindowSizeEvents { get; set; }
    }
}
