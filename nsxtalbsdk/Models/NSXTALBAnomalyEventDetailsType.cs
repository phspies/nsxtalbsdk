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
    public class NSXTALBAnomalyEventDetailsType 
    {
        public NSXTALBAnomalyEventDetailsType()
        {
        }
        /// <summary>
        /// Placeholder for description of property deviation of obj type AnomalyEventDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "deviation")]
        public double? Deviation { get; set; }
        /// <summary>
        /// metric_id of AnomalyEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricId { get; set; }
        /// <summary>
        /// metric_timestamp of AnomalyEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "metric_timestamp", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricTimestamp { get; set; }
        /// <summary>
        /// Deprecated. Enum options - EXPONENTIAL_MOVING_AVG, EXPONENTIAL_WEIGHTED_MOVING_AVG, HOLTWINTERS_AT_AS,
        /// HOLTWINTERS_AT_MS.
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string? Model { get; set; }
        /// <summary>
        /// Enum options - EXPONENTIAL_MOVING_AVG, EXPONENTIAL_WEIGHTED_MOVING_AVG, HOLTWINTERS_AT_AS, HOLTWINTERS_AT_MS.
        /// </summary>
        [JsonProperty(PropertyName = "models")]
        public IList<string> Models { get; set; }
        /// <summary>
        /// node_id of AnomalyEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// Enum options - METRICS_OBJ_TYPE_UNKNOWN, VSERVER_L4_SERVER, VSERVER_L4_CLIENT, VSERVER_L7_SERVER, VSERVER_L7_CLIENT,
        /// VM_METRICS_OBJ, SE_METRICS_OBJ, VSERVER_RUM, CONTROLLER_METRICS_OBJ, METRICS_COLLECTION, METRICS_RUM_PREAGG_BROWSER_OBJ,
        /// METRICS_RUM_PREAGG_COUNTRY_OBJ, METRICS_RUM_PREAGG_DEVTYPE_OBJ, METRICS_RUM_PREAGG_LANG_OBJ, METRICS_RUM_PREAGG_OS_OBJ,
        /// METRICS_RUM_PREAGG_URL_OBJ, METRICS_ANOMALY_OBJ, METRICS_HEALTHSCORE_OBJ, METRICS_RESOURCE_TIMING_BROWSER_OBJ,
        /// METRICS_RESOURCE_TIMING_OS_OBJ, METRICS_RESOURCE_TIMING_COUNTRY_OBJ, METRICS_RESOURCE_TIMING_LANG_OBJ,
        /// METRICS_RESOURCE_TIMING_DEVTYPE_OBJ, METRICS_RESOURCE_TIMING_URL_OBJ, METRICS_RESOURCE_TIMING_DIMENSION_OBJ,
        /// METRICS_RESOURCE_TIMING_BLOB_OBJ, METRICS_DOS_OBJ, METRICS_RUM_PREAGG_IPGROUP_OBJ, METRICS_APP_INSIGHTS_OBJ,
        /// METRICS_VSERVER_DNS_OBJ, METRICS_SERVER_DNS_OBJ, METRICS_SERVICE_INSIGHTS_OBJ, METRICS_SOURCE_INSIGHTS_OBJ,
        /// METRICS_TENANT_STATS_OBJ, METRICS_SE_IF_STATS_OBJ, METRICS_USER_METRICS_OBJ, METRICS_WAF_GROUP_OBJ,
        /// METRICS_WAF_RULE_OBJ, METRICS_WAF_TAG_OBJ, METRICS_PROCESS_STATS_OBJ, METRICS_VSERVER_HTTP2_CLIENT_OBJ,
        /// METRICS_WAF_WHITELIST_OBJ, METRICS_WAF_PSM_GROUP_OBJ, METRICS_WAF_PSMLOCATION_OBJ, METRICS_WAF_PSM_RULE_OBJ,
        /// METRICS_PG_STAT_DATABASE_OBJ, METRICS_PG_STAT_ALL_TABLES_OBJ, METRICS_PG_STAT_ALL_INDEXES_OBJ,
        /// METRICS_PG_STAT_IO_ALL_TABLES_OBJ, METRICS_PG_STAT_CLASS_OBJ, METRICS_PG_STAT_BG_WRITER_OBJ, METRICS_GSLB_STATS_OBJ,
        /// METRICS_VS_SCALEOUT_OBJ, METRICS_API_PERF_STATS_OBJ, METRICS_NSXT_STATS_OBJ, METRICS_ICAP_OBJ, METRICS_BOT_OBJ.
        /// </summary>
        [JsonProperty(PropertyName = "obj_type")]
        public string? ObjType { get; set; }
        /// <summary>
        /// pool_name of AnomalyEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// Unique object identifier of pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Enum options - ANZ_PRIORITY_HIGH, ANZ_PRIORITY_MEDIUM, ANZ_PRIORITY_LOW.
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Priority { get; set; }
        /// <summary>
        /// server of AnomalyEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type AnomalyEventDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
