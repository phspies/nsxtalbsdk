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
    public class NSXTALBSeRuntimePropertiesType 
    {
        /// <summary>
        /// Allow admin user ssh access to SE. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "admin_ssh_enabled")]
        public bool? AdminSshEnabled { get; set; }
        /// <summary>
        /// Placeholder for description of property app_headers of obj type SeRuntimeProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "app_headers")]
        public IList<NSXTALBAppHdrType> AppHeaders { get; set; }
        /// <summary>
        /// Deprecated in 21.1.3. Use config in ServiceEngineGroup instead.
        /// </summary>
        [JsonProperty(PropertyName = "baremetal_dispatcher_handles_flows")]
        public bool? BaremetalDispatcherHandlesFlows { get; set; }
        /// <summary>
        /// Rate limit on maximum adf lossy log to pushper second. Allowed in Basic(Allowed values- 1000) edition,
        /// Essentials(Allowed values- 1000) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "connections_lossy_log_rate_limiter_threshold")]
        public int? ConnectionsLossyLogRateLimiterThreshold { get; set; }
        /// <summary>
        /// Rate limit on maximum adf udf or nf log to pushper second. Allowed in Basic(Allowed values- 1000) edition,
        /// Essentials(Allowed values- 1000) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "connections_udfnf_log_rate_limiter_threshold")]
        public int? ConnectionsUdfnfLogRateLimiterThreshold { get; set; }
        /// <summary>
        /// Disable Flow Probes for Scaled out VS'es. (This field has been moved to se_group properties 20.1.3 onwards.). Field
        /// introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_flow_probes")]
        public bool? DisableFlowProbes { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.2.5. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_gro")]
        public bool? DisableGro { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.2.5. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "disable_tso")]
        public bool? DisableTso { get; set; }
        /// <summary>
        /// Placeholder for description of property dos_profile of obj type SeRuntimeProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dos_profile")]
        public NSXTALBDosThresholdProfileType DosProfile { get; set; }
        /// <summary>
        /// Timeout for downstream to become writable. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "downstream_send_timeout")]
        public int? DownstreamSendTimeout { get; set; }
        /// <summary>
        /// Frequency of SE - SE HB messages when aggressive failure mode detection is enabled. (This field has been moved to
        /// se_group properties 20.1.3 onwards). Unit is MILLISECONDS. Allowed in Basic(Allowed values- 100) edition,
        /// Essentials(Allowed values- 100) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_hb_frequency")]
        public int? DpAggressiveHbFrequency { get; set; }
        /// <summary>
        /// Consecutive HB failures after which failure is reported to controller,when aggressive failure mode detection is enabled.
        /// (This field has been moved to se_group properties 20.1.3 onwards). Allowed in Basic(Allowed values- 10) edition,
        /// Essentials(Allowed values- 10) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_hb_timeout_count")]
        public int? DpAggressiveHbTimeoutCount { get; set; }
        /// <summary>
        /// Frequency of SE - SE HB messages when aggressive failure mode detection is not enabled. (This field has been moved to
        /// se_group properties 20.1.3 onwards). Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_hb_frequency")]
        public int? DpHbFrequency { get; set; }
        /// <summary>
        /// Consecutive HB failures after which failure is reported to controller, when aggressive failure mode detection is not
        /// enabled. (This field has been moved to se_group properties 20.1.3 onwards).
        /// </summary>
        [JsonProperty(PropertyName = "dp_hb_timeout_count")]
        public int? DpHbTimeoutCount { get; set; }
        /// <summary>
        /// Frequency of ARP requests sent by SE for each VIP to detect duplicate IP when it loses conectivity to controller. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dupip_frequency")]
        public int? DupipFrequency { get; set; }
        /// <summary>
        /// Number of ARP responses received for the VIP after which SE decides that the VIP has been moved and disables the VIP.
        /// </summary>
        [JsonProperty(PropertyName = "dupip_timeout_count")]
        public int? DupipTimeoutCount { get; set; }
        /// <summary>
        /// Enable HSM luna engine logs. Field introduced in 16.4.8, 17.1.11, 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hsm_log")]
        public bool? EnableHsmLog { get; set; }
        /// <summary>
        /// Enable proxy ARP from Host interface for Front End  proxies.
        /// </summary>
        [JsonProperty(PropertyName = "feproxy_vips_enable_proxy_arp")]
        public bool? FeproxyVipsEnableProxyArp { get; set; }
        /// <summary>
        /// How often to push the flow table IPC messages in the main loop. The value is the number of times through the loop before
        /// pushing the batch. i.e, a value of 1 means every time through the loop.
        /// </summary>
        [JsonProperty(PropertyName = "flow_table_batch_push_frequency")]
        public int? FlowTableBatchPushFrequency { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "flow_table_max_entries_deprecated")]
        public int? FlowTableMaxEntriesDeprecated { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flow_table_new_syn_max_entries")]
        public int? FlowTableNewSynMaxEntries { get; set; }
        /// <summary>
        /// Overrides the MTU value received via DHCP or some other means. Use this when the infrastructure advertises an MTU that
        /// is not supported by all devices in the network. For example, in AWS or when an overlay is used.
        /// </summary>
        [JsonProperty(PropertyName = "global_mtu")]
        public int? GlobalMtu { get; set; }
        /// <summary>
        /// Enable Javascript console logs on the client browser when collecting client insights. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "http_rum_console_log")]
        public bool? HttpRumConsoleLog { get; set; }
        /// <summary>
        /// Minimum response size content length to sample for client insights. Allowed in Basic(Allowed values- 64) edition,
        /// Essentials(Allowed values- 64) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "http_rum_min_content_length")]
        public int? HttpRumMinContentLength { get; set; }
        /// <summary>
        /// How often to push the LB IPC messages in the main loop. The value is the number of times the loop has to run before
        /// pushing the batch. i.e, a value of 1 means the batch is pushed every time the loop runs. Field deprecated in 18.1.3.
        /// Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "lb_batch_push_frequency")]
        public int? LbBatchPushFrequency { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.1. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "lb_fail_max_time")]
        public int? LbFailMaxTime { get; set; }
        /// <summary>
        /// Number of requests to dispatch from the request queue at a regular interval.
        /// </summary>
        [JsonProperty(PropertyName = "lbaction_num_requests_to_dispatch")]
        public int? LbactionNumRequestsToDispatch { get; set; }
        /// <summary>
        /// Maximum retries per request in the request queue.
        /// </summary>
        [JsonProperty(PropertyName = "lbaction_rq_per_request_max_retries")]
        public int? LbactionRqPerRequestMaxRetries { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Flag to indicate if log files are compressed upon full on the Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_compress_logs")]
        public bool? LogAgentCompressLogs { get; set; }
        /// <summary>
        /// [DEPRECATED]Log-agent test property used to simulate slow TCP connections. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_conn_send_buffer_size")]
        public int? LogAgentConnSendBufferSize { get; set; }
        /// <summary>
        /// [DEPRECATED]Maximum size of data sent by log-agent to Controller over the TCP connection. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_export_msg_buffer_size")]
        public int? LogAgentExportMsgBufferSize { get; set; }
        /// <summary>
        /// [DEPRECATED]Time log-agent waits before sending data to the Controller. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_export_wait_time")]
        public int? LogAgentExportWaitTime { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum application log file size before rollover.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_appl")]
        public int? LogAgentFileSzAppl { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum connection log file size before rollover.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_conn")]
        public int? LogAgentFileSzConn { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum debug log file size before rollover.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_debug")]
        public int? LogAgentFileSzDebug { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum event log file size before rollover.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_file_sz_event")]
        public int? LogAgentFileSzEvent { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Minimum storage allocated for logs irrespective of memory and cores. Unit is MB.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_log_storage_min_sz")]
        public int? LogAgentLogStorageMinSz { get; set; }
        /// <summary>
        /// [DEPRECATED] Maximum number of Virtual Service log files maintained for significant logs on the Service Engine. Field
        /// deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_active_adf_files_per_vs")]
        public int? LogAgentMaxActiveAdfFilesPerVs { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum concurrent rsync requests initiated from log-agent to the Controller.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_concurrent_rsync")]
        public int? LogAgentMaxConcurrentRsync { get; set; }
        /// <summary>
        /// [DEPRECATED] Maximum size of serialized log message on the Service Engine. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_logmessage_proto_sz")]
        public int? LogAgentMaxLogmessageProtoSz { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Excess percentage threshold of disk size to trigger cleanup of logs on the Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_storage_excess_percent")]
        public int? LogAgentMaxStorageExcessPercent { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum storage on the disk not allocated for logs on the Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_max_storage_ignore_percent")]
        public double? LogAgentMaxStorageIgnorePercent { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Minimum storage allocated to any given VirtualService on the Service Engine.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_min_storage_per_vs")]
        public int? LogAgentMinStoragePerVs { get; set; }
        /// <summary>
        /// [DEPRECATED]Time interval log-agent pauses between logs obtained from the dataplane. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_pause_interval")]
        public int? LogAgentPauseInterval { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Internal timer to stall log-agent and prevent it from hogging CPU cycles on the Service Engine.
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_sleep_interval")]
        public int? LogAgentSleepInterval { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Timeout to purge unknown Virtual Service logs from the Service Engine. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "log_agent_unknown_vs_timer")]
        public int? LogAgentUnknownVsTimer { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Maximum number of file names in a log message.
        /// </summary>
        [JsonProperty(PropertyName = "log_message_max_file_list_size")]
        public int? LogMessageMaxFileListSize { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.1. Unit is MBPS.
        /// </summary>
        [JsonProperty(PropertyName = "max_throughput")]
        public int? MaxThroughput { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use enabled under caching in application profile. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_enabled")]
        public bool? McacheEnabled { get; set; }
        /// <summary>
        /// enables mcache_fetch. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_fetch_enabled")]
        public bool? McacheFetchEnabled { get; set; }
        /// <summary>
        /// Use SE Group's app_cache_percent to set cache memory usage limit on SE. Field deprecated in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_max_cache_size")]
        public long? McacheMaxCacheSize { get; set; }
        /// <summary>
        /// enables mcache_store. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_store_in_enabled")]
        public bool? McacheStoreInEnabled { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use max_object_size under caching in application profile. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_store_in_max_size")]
        public int? McacheStoreInMaxSize { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use min_object_size under caching in application profile. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_store_in_min_size")]
        public int? McacheStoreInMinSize { get; set; }
        /// <summary>
        /// enables mcache_store_out. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_store_out_enabled")]
        public bool? McacheStoreOutEnabled { get; set; }
        /// <summary>
        /// Use SE Group's app_cache_percent to set cache memory usage limit on SE. Field deprecated in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "mcache_store_se_max_size")]
        public long? McacheStoreSeMaxSize { get; set; }
        /// <summary>
        /// Placeholder for description of property ngx_free_connection_stack of obj type SeRuntimeProperties field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "ngx_free_connection_stack")]
        public bool? NgxFreeConnectionStack { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_entries_low_watermark")]
        public int? PersistenceEntriesLowWatermark { get; set; }
        /// <summary>
        /// Maximum memory in bytes allocated for persistence entries. Allowed values are 0-33554432.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_mem_max")]
        public int? PersistenceMemMax { get; set; }
        /// <summary>
        /// Enable punting of UDP packets from primary to other Service Engines. This applies to Virtual Services with Per-Packet
        /// Loadbalancing enabled.
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_udp_per_pkt")]
        public bool? ScaleoutUdpPerPkt { get; set; }
        /// <summary>
        /// LDAP basicauth default bind timeout enforced on connections to LDAP server. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_bind_timeout")]
        public int? SeAuthLdapBindTimeout { get; set; }
        /// <summary>
        /// Size of LDAP basicauth credentials cache used on the dataplane. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_cache_size")]
        public int? SeAuthLdapCacheSize { get; set; }
        /// <summary>
        /// LDAP basicauth default connection timeout enforced on connections to LDAP server. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_connect_timeout")]
        public int? SeAuthLdapConnectTimeout { get; set; }
        /// <summary>
        /// Number of concurrent connections to LDAP server by a single basic auth LDAP process.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_conns_per_server")]
        public int? SeAuthLdapConnsPerServer { get; set; }
        /// <summary>
        /// LDAP basicauth default reconnect timeout enforced on connections to LDAP server. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_reconnect_timeout")]
        public int? SeAuthLdapReconnectTimeout { get; set; }
        /// <summary>
        /// LDAP basicauth default login or group search request timeout enforced on connections to LDAP server. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_request_timeout")]
        public int? SeAuthLdapRequestTimeout { get; set; }
        /// <summary>
        /// LDAP basicauth uses multiple ldap servers in the event of a failover only.
        /// </summary>
        [JsonProperty(PropertyName = "se_auth_ldap_servers_failover_only")]
        public bool? SeAuthLdapServersFailoverOnly { get; set; }
        /// <summary>
        /// Placeholder for description of property se_dp_compression of obj type SeRuntimeProperties field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_compression")]
        public NSXTALBSeRuntimeCompressionPropertiesType SeDpCompression { get; set; }
        /// <summary>
        /// Deprecated - This field has been moved to se_group properties 20.1.3 onwards. Internal only. Used to simulate SE - SE HB
        /// failure.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_hm_drops")]
        public int? SeDpHmDrops { get; set; }
        /// <summary>
        /// Deprecated in 21.1.3. Use config in ServiceEngineGroup instead.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_if_state_poll_interval")]
        public int? SeDpIfStatePollInterval { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Internal buffer full indicator on the Service Engine beyond which the unfiltered logs are
        /// abandoned.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_log_nf_enqueue_percent")]
        public int? SeDpLogNfEnqueuePercent { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Internal buffer full indicator on the Service Engine beyond which the user filtered logs are
        /// abandoned.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_log_udf_enqueue_percent")]
        public int? SeDpLogUdfEnqueuePercent { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_queue_stall_event_sleep")]
        public int? SeDpVnicQueueStallEventSleep { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_queue_stall_threshold")]
        public int? SeDpVnicQueueStallThreshold { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_queue_stall_timeout")]
        public int? SeDpVnicQueueStallTimeout { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5. Field introduced in 17.1.14, 17.2.5, 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_restart_on_queue_stall_count")]
        public int? SeDpVnicRestartOnQueueStallCount { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.5. Field introduced in 17.1.14, 17.2.5, 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dp_vnic_stall_se_restart_window")]
        public int? SeDpVnicStallSeRestartWindow { get; set; }
        /// <summary>
        /// Deprecated in 21.1.3. Use config in ServiceEngineGroup instead. Field introduced in 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_dump_core_on_assert")]
        public bool? SeDumpCoreOnAssert { get; set; }
        /// <summary>
        /// Accept/ignore interface routes (i.e, no next hop IP address).
        /// </summary>
        [JsonProperty(PropertyName = "se_handle_interface_routes")]
        public bool? SeHandleInterfaceRoutes { get; set; }
        /// <summary>
        /// Internal use only. Allowed values are 0-7.
        /// </summary>
        [JsonProperty(PropertyName = "se_hb_persist_fudge_bits")]
        public int? SeHbPersistFudgeBits { get; set; }
        /// <summary>
        /// Number of packets with wrong mac after which SE attempts to disable promiscious mode.
        /// </summary>
        [JsonProperty(PropertyName = "se_mac_error_threshold_to_disable_promiscious")]
        public int? SeMacErrorThresholdToDisablePromiscious { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_malloc_thresh")]
        public int? SeMallocThresh { get; set; }
        /// <summary>
        /// Internal use only. Enables poisoning of freed memory blocks.
        /// </summary>
        [JsonProperty(PropertyName = "se_memory_poison")]
        public bool? SeMemoryPoison { get; set; }
        /// <summary>
        /// Internal use only. Frequency (ms) of metrics updates from SE to controller. Unit is MILLISECONDS. Allowed in
        /// Basic(Allowed values- 60000) edition, Essentials(Allowed values- 60000) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "se_metrics_interval")]
        public int? SeMetricsInterval { get; set; }
        /// <summary>
        /// Internal use only. Enable or disable real time metrics irrespective of virtualservice or SE group configuration. Allowed
        /// in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition. Special default
        /// for Basic edition is false, Essentials edition is false, Enterprise is True.
        /// </summary>
        [JsonProperty(PropertyName = "se_metrics_rt_enabled")]
        public bool? SeMetricsRtEnabled { get; set; }
        /// <summary>
        /// Internal use only. Frequency (ms) of realtime metrics updates from SE to controller. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "se_metrics_rt_interval")]
        public int? SeMetricsRtInterval { get; set; }
        /// <summary>
        /// Deprecated in 21.1.3. Use config in ServiceEngineGroup instead.
        /// </summary>
        [JsonProperty(PropertyName = "se_packet_buffer_max")]
        public int? SePacketBufferMax { get; set; }
        /// <summary>
        /// Internal use only. If enabled, randomly packets are dropped.
        /// </summary>
        [JsonProperty(PropertyName = "se_random_tcp_drops")]
        public bool? SeRandomTcpDrops { get; set; }
        /// <summary>
        /// SE rate limiters.
        /// </summary>
        [JsonProperty(PropertyName = "se_rate_limiters")]
        public NSXTALBSeRateLimitersType SeRateLimiters { get; set; }
        /// <summary>
        /// IP ranges on which there may be virtual services (for configuring iptables/routes). Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "service_ip_subnets")]
        public IList<NSXTALBIpAddrPrefixType> ServiceIpSubnets { get; set; }
        /// <summary>
        /// Port ranges on which there may be virtual services (for configuring iptables). Applicable in container ecosystems like
        /// Mesos.
        /// </summary>
        [JsonProperty(PropertyName = "service_port_ranges")]
        public IList<NSXTALBPortRangeType> ServicePortRanges { get; set; }
        /// <summary>
        /// Make service ports accessible on all Host interfaces in addition to East-West VIP and/or bridge IP.
        /// </summary>
        [JsonProperty(PropertyName = "services_accessible_all_interfaces")]
        public bool? ServicesAccessibleAllInterfaces { get; set; }
        /// <summary>
        /// Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "spdy_fwd_proxy_parse_enable")]
        public bool? SpdyFwdProxyParseEnable { get; set; }
        /// <summary>
        /// Maximum size of the SYN cache table. After this limit is reached, SYN cookies are used. This is per core of the
        /// serviceengine. Field deprecated in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_syn_cache_max")]
        public int? TcpSynCacheMax { get; set; }
        /// <summary>
        /// Default value for max number of retransmissions for a SYN packet.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_syncache_max_retransmit_default")]
        public int? TcpSyncacheMaxRetransmitDefault { get; set; }
        /// <summary>
        /// Timeout for backend connection. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connect_timeout")]
        public int? UpstreamConnectTimeout { get; set; }
        /// <summary>
        /// L7 Upstream Connection pool cache threshold in percentage.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_cache_thresh")]
        public int? UpstreamConnpoolCacheThresh { get; set; }
        /// <summary>
        /// Idle timeout value for a connection in the upstream connection pool, when the current cache size is above the threshold.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_idle_thresh_tmo")]
        public int? UpstreamConnpoolConnIdleThreshTmo { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_idle_tmo")]
        public int? UpstreamConnpoolConnIdleTmo { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_life_tmo")]
        public int? UpstreamConnpoolConnLifeTmo { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_max_reuse")]
        public int? UpstreamConnpoolConnMaxReuse { get; set; }
        /// <summary>
        /// L7 Upstream Connection pool max cache size per core.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_core_max_cache")]
        public int? UpstreamConnpoolCoreMaxCache { get; set; }
        /// <summary>
        /// Enable upstream connection pool.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_enable")]
        public bool? UpstreamConnpoolEnable { get; set; }
        /// <summary>
        /// Deprecated. Field deprecated in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_server_max_cache")]
        public int? UpstreamConnpoolServerMaxCache { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1, set in application profile. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_strategy")]
        public int? UpstreamConnpoolStrategy { get; set; }
        /// <summary>
        /// Placeholder for description of property upstream_keepalive of obj type SeRuntimeProperties field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "upstream_keepalive")]
        public bool? UpstreamKeepalive { get; set; }
        /// <summary>
        /// Timeout for data to be received from backend. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_read_timeout")]
        public int? UpstreamReadTimeout { get; set; }
        /// <summary>
        /// Timeout for upstream to become writable. Unit is MILLISECONDS. Allowed in Basic(Allowed values- 3600000) edition,
        /// Essentials(Allowed values- 3600000) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_send_timeout")]
        public int? UpstreamSendTimeout { get; set; }
        /// <summary>
        /// Defines in seconds how long before an unused user-defined-metric is garbage collected. Field introduced in 17.1.5. Unit
        /// is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "user_defined_metric_age")]
        public int? UserDefinedMetricAge { get; set; }
    }
}
