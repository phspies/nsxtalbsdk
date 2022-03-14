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
    public class NSXTALBMetricsDerivationDataType 
    {
        /// <summary>
        /// Enum options - METRICS_ALIAS, SUM_FIRST_N_DIVIDE_BY_LAST, SUM_BW_GAUGE, AVG_GET_POST_OTHER_LATENCY, APPDEX_ON_3_BUCKETS,
        /// APPDEX_ON_4_BUCKETS, SUM_GAUGE, SUM_N_METRICS, APPDEX_ON_5_BUCKETS, APPDEX_ON_6_BUCKETS, APPDEX_ON_CONNECTIONS,
        /// APPDEX_ON_2_BUCKETS, AVG_CLIENT_LATENCY, AVG_APPLICATION_LATENCY, MIN_N_METRICS, SUM_FIRST_N_DIVIDE_BY_LAST_PERCENTAGE,
        /// L4_CONNECTION_ERROR_PERCENTAGE, AVG_L4_CLIENT_LATENCY, CHECK_FOR_TRANSITIONS, SUBSTRACT_ALL_FROM_FIRST,
        /// AVG_N_OVER_TIME_PERIOD, AVG_NAVIGATION_TIMING, AVG_RUM_VISITS, PCT_SSL_ERROR_CONNECTIONS, AVG_RESPONSE_TIME,
        /// SUM_RATES_FIRST_N_DIVIDE_BY_LAST, SUM_RATES_FIRST_N_DIVIDE_BY_LAST_PERCENTAGE, PCT_CACHE_METRICS,
        /// SUM_FIRST_N_DIVIDE_BY_SECLAST_EXCL_ERROR_RATE, SUM_FIRST_N_SUBSTRACT_LAST, AVG_POOL_METRICS, AVG_POOL_BW,
        /// AVG_BY_SUBSTRACT_ALL_FROM_FIRST_OVER_TIME, AVG_RSA_PFS, EVAL_FN, SSL_PROTOCOL_INDICATOR,
        /// SUM_FIRST_N_DIVIDE_BY_SECLAST_RATE_EXCL_ERROR_RATE, SUBSTRACT_ALL_FROM_FIRST_WITH_FLOOR_ZERO, AVAILABLE_CAPACITY,
        /// CONNECTION_SATURATION, AVG_RSA_NON_PFS, SSL_HANDSHAKES_NONPFS, DYN_MEM_USAGE,
        /// FIRST_DIVIDE_BY_DIFFERENCE_OF_SECOND_AND_THIRD, DIVIDE_BY_100.
        /// </summary>
        [JsonProperty(PropertyName = "derivation_fn", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string DerivationFn { get; set; }
        /// <summary>
        /// Placeholder for description of property exclude_derived_metric of obj type MetricsDerivationData field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "exclude_derived_metric")]
        public bool? ExcludeDerivedMetric { get; set; }
        /// <summary>
        /// Placeholder for description of property include_derivation_metrics of obj type MetricsDerivationData field type str 
        /// type boolean
        /// </summary>
        [JsonProperty(PropertyName = "include_derivation_metrics")]
        public bool? IncludeDerivationMetrics { get; set; }
        /// <summary>
        /// Enum options - METRICS_TABLE_NONE, METRICS_TABLE_ANOMALY, METRICS_TABLE_CONTROLLER_STATS, METRICS_TABLE_HEALTH_SCORE,
        /// METRICS_TABLE_SE_STATS, METRICS_TABLE_VSERVER_L4_SERVER, METRICS_TABLE_VSERVER_L4_CLIENT,
        /// METRICS_TABLE_VSERVER_L7_CLIENT, METRICS_TABLE_VSERVER_L7_SERVER, METRICS_TABLE_RUM_PREAGG_BROWSER,
        /// METRICS_TABLE_RUM_PREAGG_COUNTRY, METRICS_TABLE_RUM_PREAGG_DEVTYPE, METRICS_TABLE_RUM_PREAGG_LANG,
        /// METRICS_TABLE_RUM_PREAGG_OS, METRICS_TABLE_RUM_PREAGG_URL, METRICS_TABLE_RUM_ANALYTICS, METRICS_TABLE_VM_STATS,
        /// METRICS_TABLE_RESOURCE_TIMING_DIM, METRICS_TABLE_RESOURCE_TIMING_BLOB, METRICS_TABLE_RUM_PREAGG_IPGROUP,
        /// METRICS_TABLE_DOS_ANALYTICS, METRICS_TABLE_APP_INSIGHTS, METRICS_TABLE_VSERVER_DNS, METRICS_TABLE_SERVER_DNS,
        /// METRICS_TABLE_SERVICE_INSIGHTS, METRICS_TABLE_SOURCE_INSIGHTS, METRICS_TABLE_TENANT_STATS, METRICS_TABLE_SE_IF_STATS,
        /// METRICS_TABLE_USER_METRICS, METRICS_TABLE_WAF_GROUP, METRICS_TABLE_WAF_TAG, METRICS_TABLE_WAF_RULE,
        /// METRICS_TABLE_PROCESS_STATS, METRICS_TABLE_VSERVER_HTTP2_CLIENT, METRICS_TABLE_PG_STAT_DATABASE,
        /// METRICS_TABLE_PG_STAT_ALL_TABLES, METRICS_TABLE_PG_STAT_ALL_INDEXES, METRICS_TABLE_PG_STAT_IO_ALL_TABLES,
        /// METRICS_TABLE_PG_STAT_CLASS, METRICS_TABLE_PG_STAT_BG_WRITER, METRICS_TABLE_WAF_WHITELIST, METRICS_TABLE_WAF_PSMGROUP,
        /// METRICS_TABLE_WAF_PSMLOCATION, METRICS_TABLE_WAF_PSMRULE, METRICS_TABLE_GSLB_STATS, METRICS_TABLE_VS_SCALEOUT,
        /// METRICS_TABLE_API_PERF_STATS, METRICS_TABLE_NSXT_STATS, METRICS_TABLE_ICAP, METRICS_TABLE_BOT.
        /// </summary>
        [JsonProperty(PropertyName = "join_tables")]
        public string? JoinTables { get; set; }
        /// <summary>
        /// metric_ids of MetricsDerivationData.
        /// </summary>
        [JsonProperty(PropertyName = "metric_ids", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricIds { get; set; }
        /// <summary>
        /// Placeholder for description of property result_has_additional_fields of obj type MetricsDerivationData field type str 
        /// type boolean
        /// </summary>
        [JsonProperty(PropertyName = "result_has_additional_fields")]
        public bool? ResultHasAdditionalFields { get; set; }
        /// <summary>
        /// Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "second_order_derivation")]
        public bool? SecondOrderDerivation { get; set; }
        /// <summary>
        /// Placeholder for description of property skip_backend_derivation of obj type MetricsDerivationData field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "skip_backend_derivation")]
        public bool? SkipBackendDerivation { get; set; }
    }
}
