using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeAgentPropertiesType
    {
        /// <summary>
        /// Aggressive Count of HB misses for se health check failure. Allowed values are 1-1000.
        /// </summary>
        [JsonProperty(PropertyName = "controller_echo_miss_aggressive_limit")]
        public int? ControllerEchoMissAggressiveLimit { get; set; }
        /// <summary>
        /// Count of HB misses for se health check failure. Allowed values are 1-1000.
        /// </summary>
        [JsonProperty(PropertyName = "controller_echo_miss_limit")]
        public int? ControllerEchoMissLimit { get; set; }
        /// <summary>
        /// Aggressive Timeout used for se health check. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "controller_echo_rpc_aggressive_timeout")]
        public int? ControllerEchoRpcAggressiveTimeout { get; set; }
        /// <summary>
        /// Timeout used for se health check. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "controller_echo_rpc_timeout")]
        public int? ControllerEchoRpcTimeout { get; set; }
        /// <summary>
        /// Allowed values are 1-20.
        /// </summary>
        [JsonProperty(PropertyName = "controller_heartbeat_miss_limit")]
        public int? ControllerHeartbeatMissLimit { get; set; }
        /// <summary>
        /// Allowed values are 1-60. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "controller_heartbeat_timeout_sec")]
        public int? ControllerHeartbeatTimeoutSec { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "controller_registration_timeout_sec")]
        public int? ControllerRegistrationTimeoutSec { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "controller_rpc_timeout")]
        public int? ControllerRpcTimeout { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "cpustats_interval")]
        public int? CpustatsInterval { get; set; }
        /// <summary>
        /// Max time to wait for ctrl registration before assert. Allowed values are 1-1000. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "ctrl_reg_pending_max_wait_time")]
        public int? CtrlRegPendingMaxWaitTime { get; set; }
        /// <summary>
        /// Placeholder for description of property debug_mode of obj type SeAgentProperties field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "debug_mode")]
        public bool? DebugMode { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use dp_aggressive_deq_interval_msec in ServiceEngineGroup instead. Allowed values are 1-1000. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_deq_interval_msec")]
        public int? DpAggressiveDeqIntervalMsec { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use dp_aggressive_enq_interval_msec in ServiceEngineGroup instead. Allowed values are 1-1000. Unit
        /// is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_aggressive_enq_interval_msec")]
        public int? DpAggressiveEnqIntervalMsec { get; set; }
        /// <summary>
        /// Number of dp_batch_size.
        /// </summary>
        [JsonProperty(PropertyName = "dp_batch_size")]
        public int? DpBatchSize { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use dp_deq_interval_msec in ServiceEngineGroup instead. Allowed values are 1-1000. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_deq_interval_msec")]
        public int? DpDeqIntervalMsec { get; set; }
        /// <summary>
        /// Deprecated in 21.1.1. Use dp_enq_interval_msec in ServiceEngineGroup instead. Allowed values are 1-1000. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dp_enq_interval_msec")]
        public int? DpEnqIntervalMsec { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "dp_max_wait_rsp_time_sec")]
        public int? DpMaxWaitRspTimeSec { get; set; }
        /// <summary>
        /// Max time to wait for dp registration before assert. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "dp_reg_pending_max_wait_time")]
        public int? DpRegPendingMaxWaitTime { get; set; }
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "headless_timeout_sec")]
        public int? HeadlessTimeoutSec { get; set; }
        /// <summary>
        /// Deprecated in 21.1.3. Use config in ServiceEngineGroup instead.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_docker_mac_change")]
        public bool? IgnoreDockerMacChange { get; set; }
        /// <summary>
        /// Dequeue interval for receive queue from NS HELPER. Deprecated in 21.1.1. Use ns_helper_deq_interval_msec in
        /// ServiceEngineGroup instead. Allowed values are 1-1000. Field introduced in 17.2.13, 18.1.3, 18.2.1. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "ns_helper_deq_interval_msec")]
        public int? NsHelperDeqIntervalMsec { get; set; }
        /// <summary>
        /// SDB pipeline flush interval. Deprecated in 21.1.1. Use sdb_flush_interval ServiceEngineGroup instead. Allowed values are
        /// 1-10000. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "sdb_flush_interval")]
        public int? SdbFlushInterval { get; set; }
        /// <summary>
        /// SDB pipeline size. Deprecated in 21.1.1. Use sdb_pipeline_size ServiceEngineGroup instead. Allowed values are 1-10000.
        /// </summary>
        [JsonProperty(PropertyName = "sdb_pipeline_size")]
        public int? SdbPipelineSize { get; set; }
        /// <summary>
        /// SDB scan count. Deprecated in 21.1.1. Use sdb_scan_count ServiceEngineGroup instead. Allowed values are 1-1000.
        /// </summary>
        [JsonProperty(PropertyName = "sdb_scan_count")]
        public int? SdbScanCount { get; set; }
        /// <summary>
        /// Internal flag used to decide if SE restart is needed,when the se-group is changed. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_change_disruptive")]
        public bool? SeGrpChangeDisruptive { get; set; }
        /// <summary>
        /// SeAgent properties for State Cache functionality. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "seagent_statecache_properties")]
        public NSXTALBSeAgentStateCachePropertiesType SeagentStatecacheProperties { get; set; }
        /// <summary>
        /// Timeout for sending SE_READY without NS HELPER registration completion. Deprecated in 21.1.1. Use send_se_ready_timeout
        /// ServiceEngineGroup instead. Allowed values are 10-600. Field introduced in 17.2.13, 18.1.3, 18.2.1. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "send_se_ready_timeout")]
        public int? SendSeReadyTimeout { get; set; }
        /// <summary>
        /// Interval for update of operational states to controller. Allowed values are 1-10000. Field introduced in 18.2.1,
        /// 17.2.14, 18.1.5. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "states_flush_interval")]
        public int? StatesFlushInterval { get; set; }
        /// <summary>
        /// DHCP ip check interval. Deprecated in 21.1.1. Use vnic_dhcp_ip_check_interval instead. Allowed values are 1-1000. Unit
        /// is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_dhcp_ip_check_interval")]
        public int? VnicDhcpIpCheckInterval { get; set; }
        /// <summary>
        /// DHCP ip max retries. Deprecated in 21.1.1. Use vnic_dhcp_ip_max_retries ServiceEngineGroup instead.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_dhcp_ip_max_retries")]
        public int? VnicDhcpIpMaxRetries { get; set; }
        /// <summary>
        /// wait interval before deleting IP. Deprecated in 21.1.1. Use vnic_ip_delete_interval ServiceEngineGroup instead. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_ip_delete_interval")]
        public int? VnicIpDeleteInterval { get; set; }
        /// <summary>
        /// Probe vnic interval. Deprecated in 21.1.1. Use vnic_probe_interval ServiceEngineGroup instead. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_probe_interval")]
        public int? VnicProbeInterval { get; set; }
        /// <summary>
        /// Time interval for retrying the failed VNIC RPC requestsDeprecated in 21.1.1. Use vnic_rpc_retry_interval
        /// ServiceEngineGroup instead. Field introduced in 18.2.6. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "vnic_rpc_retry_interval")]
        public int? VnicRpcRetryInterval { get; set; }
        /// <summary>
        /// Size of vnicdb command history. Deprecated in 21.1.1. Use vnicdb_cmd_history_size ServiceEngineGroup instead. Allowed
        /// values are 0-65535. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "vnicdb_cmd_history_size")]
        public int? VnicdbCmdHistorySize { get; set; }
    }
}
