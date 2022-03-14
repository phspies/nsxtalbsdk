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
    public class NSXTALBDebugFilterUnionType 
    {
        public NSXTALBDebugFilterUnionType()
        {
        }
        /// <summary>
        /// Placeholder for description of property alert_debug_filter of obj type DebugFilterUnion field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "alert_debug_filter")]
        public NSXTALBAlertMgrDebugFilterType AlertDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property autoscale_mgr_debug_filter of obj type DebugFilterUnion field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_mgr_debug_filter")]
        public NSXTALBAutoScaleMgrDebugFilterType AutoscaleMgrDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property cloud_connector_debug_filter of obj type DebugFilterUnion field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "cloud_connector_debug_filter")]
        public NSXTALBCloudConnectorDebugFilterType CloudConnectorDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property hs_debug_filter of obj type DebugFilterUnion field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_debug_filter")]
        public NSXTALBHSMgrDebugFilterType HsDebugFilter { get; set; }
        /// <summary>
        /// Add filter to Log Manager Debug. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "logmanager_debug_filter")]
        public NSXTALBLogManagerDebugFilterType LogmanagerDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property mesos_metrics_debug_filter of obj type DebugFilterUnion field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "mesos_metrics_debug_filter")]
        public NSXTALBMesosMetricsDebugFilterType MesosMetricsDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_debug_filter of obj type DebugFilterUnion field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "metrics_debug_filter")]
        public NSXTALBMetricsMgrDebugFilterType MetricsDebugFilter { get; set; }
        /// <summary>
        /// Add Metricsapi Server filter. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "metricsapi_srv_debug_filter")]
        public NSXTALBMetricsApiSrvDebugFilterType MetricsapiSrvDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property se_mgr_debug_filter of obj type DebugFilterUnion field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_mgr_debug_filter")]
        public NSXTALBSeMgrDebugFilterType SeMgrDebugFilter { get; set; }
        /// <summary>
        /// Add SE RPC Proxy Filter. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_rpc_proxy_filter")]
        public NSXTALBSeRpcProxyDebugFilterType SeRpcProxyFilter { get; set; }
        /// <summary>
        /// Add Metricsapi Server filter. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "securitymgr_debug_filter")]
        public NSXTALBSecurityMgrDebugFilterType SecuritymgrDebugFilter { get; set; }
        /// <summary>
        /// Placeholder for description of property state_cache_mgr_debug_filter of obj type DebugFilterUnion field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "state_cache_mgr_debug_filter")]
        public NSXTALBStateCacheMgrDebugFilterType StateCacheMgrDebugFilter { get; set; }
        /// <summary>
        /// Enum options - TASK_QUEUE_DEBUG, RPC_INFRA_DEBUG, JOB_MGR_DEBUG, TRANSACTION_DEBUG, SE_AGENT_DEBUG,
        /// SE_AGENT_METRICS_DEBUG, VIRTUALSERVICE_DEBUG, RES_MGR_DEBUG, SE_MGR_DEBUG, VI_MGR_DEBUG, METRICS_MANAGER_DEBUG,
        /// METRICS_MGR_DEBUG, EVENT_API_DEBUG, HS_MGR_DEBUG, ALERT_MGR_DEBUG, AUTOSCALE_MGR_DEBUG, APIC_AGENT_DEBUG,
        /// REDIS_INFRA_DEBUG, CLOUD_CONNECTOR_DEBUG, MESOS_METRICS_DEBUG, STATECACHE_MGR_DEBUG, NSX_AGENT_DEBUG,
        /// SE_AGENT_CPU_UTIL_DEBUG, SE_AGENT_MEM_UTIL_DEBUG, SE_RPC_PROXY_DEBUG, SE_AGENT_GSLB_DEBUG, METRICSAPI_SRV_DEBUG,
        /// SECURITYMGR_DEBUG, RES_MGR_READ_DEBUG, LICENSE_VMWSRVR_DEBUG, SE_AGENT_RESOLVERDB_DEBUG, LOGMANAGER_DEBUG, OSYNC_DEBUG.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_debug_filter of obj type DebugFilterUnion field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_debug_filter")]
        public NSXTALBVsDebugFilterType VsDebugFilter { get; set; }
    }
}
