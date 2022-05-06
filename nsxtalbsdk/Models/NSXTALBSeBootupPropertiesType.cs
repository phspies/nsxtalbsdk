using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeBootupPropertiesType
    {
        /// <summary>
        /// Deprecated. Field deprecated in 17.2.8. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "distribute_queues")]
        public bool? DistributeQueues { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "distribute_vnics")]
        public bool? DistributeVnics { get; set; }
        /// <summary>
        /// End of the Local TCP port range used by SE for backend connections in docker environment.
        /// </summary>
        [JsonProperty(PropertyName = "docker_backend_portend")]
        public int? DockerBackendPortend { get; set; }
        /// <summary>
        /// Start of the Local TCP port range used by SE for backend connections in docker environment.
        /// </summary>
        [JsonProperty(PropertyName = "docker_backend_portstart")]
        public int? DockerBackendPortstart { get; set; }
        /// <summary>
        /// Enable or disable fair queueing for packet transmission among virtualservices on an SE.
        /// </summary>
        [JsonProperty(PropertyName = "fair_queueing_enabled")]
        public bool? FairQueueingEnabled { get; set; }
        /// <summary>
        /// Granularity or Resolution of co-ordinates used. When the value is 1 the co-ordinates provided in the geo-db are used as
        /// is (highest resolution.This value provides a 'zoom-out' value so that coarser co-ordinates are used. With higher
        /// resolution, logs can contain finer location information. But, lower resolution provides significant memory and cpu
        /// benefits on the service engine. Besides, given a smaller number of members that are separated geographically, a lower
        /// resolution is sufficient for correct load-balancing. Allowed values are 1-20. Field introduced in 17.1.1. Allowed in
        /// Basic(Allowed values- 1) edition, Essentials(Allowed values- 1) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "geo_db_granularity")]
        public int? GeoDbGranularity { get; set; }
        /// <summary>
        /// Number of L7 connections that can be cached per core.
        /// </summary>
        [JsonProperty(PropertyName = "l7_conns_per_core")]
        public int? L7ConnsPerCore { get; set; }
        /// <summary>
        /// Number of reserved L7 listener connections per core.
        /// </summary>
        [JsonProperty(PropertyName = "l7_resvd_listen_conns_per_core")]
        public int? L7ResvdListenConnsPerCore { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Enable debug logs by default on Service Engine. This includes all other debugging logs. Debug logs
        /// can also be explcitly enabled from the CLI shell.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_debug_enabled")]
        public bool? LogAgentDebugEnabled { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Enable trace logs by default on Service Engine. Configuration operations are logged along with
        /// other important logs by Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_trace_enabled")]
        public bool? LogAgentTraceEnabled { get; set; }
        /// <summary>
        /// Placeholder for description of property se_dp_compression of obj type SeBootupProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_compression")]
        public NSXTALBSeBootupCompressionPropertiesType SeDpCompression { get; set; }
        /// <summary>
        /// This field has been moved to se_group properties 18.1.2 onwards. Field deprecated in 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_dpdk_pmd")]
        public int? SeDpdkPmd { get; set; }
        /// <summary>
        /// Deprecated in 21.1.3. Use config in ServiceEngineGroup instead. Allowed in Basic(Allowed values- 0) edition,
        /// Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_emulated_cores")]
        public int? SeEmulatedCores { get; set; }
        /// <summary>
        /// Determines if SE-SE IPC messages are encapsulated in an IP header   Note  This field has been moved to se_group
        /// properties 20.1.3 onwards.    0        Automatically determine based on hypervisor type    1        Use IP encap
        /// unconditionally    ~[0,1]   Don't use IP encap.
        /// </summary>
        [JsonProperty(PropertyName = "se_ip_encap_ipc")]
        public int? SeIpEncapIpc { get; set; }
        /// <summary>
        /// Determines if SE-SE IPC messages use SE interface IP instead of VIP    Note  This field has been moved to se_group
        /// properties 20.1.3 onwards.    0        Automatically determine based on hypervisor type    1        Use SE interface IP
        /// unconditionally    ~[0,1]   Don't use SE interface IP.
        /// </summary>
        [JsonProperty(PropertyName = "se_l3_encap_ipc")]
        public int? SeL3EncapIpc { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Internal flag that blocks dataplane until all application logs are flushed to log-agent process.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_app_blocking_dequeue")]
        public bool? SeLogBufferAppBlockingDequeue { get; set; }
        /// <summary>
        /// Internal application log buffer size to use on Service Engine. Can be fine tuned for better performance of data plane in
        /// specific environments. Unit is WORD.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_applog_size")]
        public int? SeLogBufferApplogSize { get; set; }
        /// <summary>
        /// Number of internal buffer chunks to use on Service Engine. Can be fine tuned for better performance of data plane in
        /// specific environments. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_chunk_count")]
        public int? SeLogBufferChunkCount { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Internal flag that blocks dataplane until all connection logs are flushed to log-agent process.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_conn_blocking_dequeue")]
        public bool? SeLogBufferConnBlockingDequeue { get; set; }
        /// <summary>
        /// Internal connection log buffer size to use on Service Engine. Can be fine tuned for better performance of data plane in
        /// specific environments. Unit is WORD.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_connlog_size")]
        public int? SeLogBufferConnlogSize { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Internal flag that blocks dataplane until all outstanding events are flushed to log-agent process.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_events_blocking_dequeue")]
        public bool? SeLogBufferEventsBlockingDequeue { get; set; }
        /// <summary>
        /// Internal events buffer size to use on Service Engine. Can be fine tuned for better performance of data plane in specific
        /// environments. Unit is WORD.
        /// </summary>
        [JsonProperty(PropertyName = "se_log_buffer_events_size")]
        public int? SeLogBufferEventsSize { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_lro")]
        public int? SeLro { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_pkt_count")]
        public int? SePcapPktCount { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_pcap_pkt_sz")]
        public int? SePcapPktSz { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_nav_interval")]
        public int? SeRumSamplingNavInterval { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_nav_percent")]
        public int? SeRumSamplingNavPercent { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_res_interval")]
        public int? SeRumSamplingResInterval { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_rum_sampling_res_percent")]
        public int? SeRumSamplingResPercent { get; set; }
        /// <summary>
        /// Determines if DSR from secondary SE is active or not      0        Automatically determine based on hypervisor type    1
        /// Disable DSR unconditionally    ~[0,1]   Enable DSR unconditionally. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_tunnel_mode")]
        public int? SeTunnelMode { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_tx_batch_size")]
        public int? SeTxBatchSize { get; set; }
        /// <summary>
        /// This field has been moved to se_group properties 18.1.2 onwards. Field deprecated in 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_use_dpdk")]
        public int? SeUseDpdk { get; set; }
        /// <summary>
        /// Number of ssl_sess_cache_per_vs.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_sess_cache_per_vs")]
        public int? SslSessCachePerVs { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1, use session timeout in ssl profile. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_sess_cache_timeout")]
        public int? SslSessCacheTimeout { get; set; }
        /// <summary>
        /// Size of the TCP SYN cache hash table.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_syncache_hashsize")]
        public int? TcpSyncacheHashsize { get; set; }
    }
}
