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
    public class NSXTALBHealthScoreQueryType 
    {
        public NSXTALBHealthScoreQueryType()
        {
        }
        /// <summary>
        /// Return detailed header with information like contributors etc.?.
        /// </summary>
        [JsonProperty(PropertyName = "detailed_header")]
        public bool? DetailedHeader { get; set; }
        /// <summary>
        /// Aggregations for dimensions. Eg. use dimenstion_aggregation=avg for averaged metric values. Enum options -
        /// METRICS_DIMENSION_AGG_NONE, METRICS_DIMENSION_AGG_AVG, METRICS_DIMENSION_AGG_SUM, METRICS_DIMENSION_AGG_MAX,
        /// METRICS_DIMENSION_AGG_MIN, METRICS_DIMENSION_AGG_PERCENT, METRICS_DIMENSION_AGG_ALL.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_aggregation")]
        public string? DimensionAggregation { get; set; }
        /// <summary>
        /// UUID of the entity type.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string EntityUuid { get; set; }
        /// <summary>
        /// Health Score Type. Enum options - HEALTH_SCORE, HEALTH_PERFORMANCE_SCORE, HEALTH_ANOMALY_SCORE, HEALTH_RESOURCES_SCORE,
        /// HEALTH_SECURITY_THREAT_LEVEL.
        /// </summary>
        [JsonProperty(PropertyName = "hs_type")]
        public string? HsType { get; set; }
        /// <summary>
        /// Resolve uuid to references?.
        /// </summary>
        [JsonProperty(PropertyName = "include_refs")]
        public bool? IncludeRefs { get; set; }
        /// <summary>
        /// Include statistics when no filters specified?.
        /// </summary>
        [JsonProperty(PropertyName = "include_statistics")]
        public bool? IncludeStatistics { get; set; }
        /// <summary>
        /// Max number of metric samples to be returned in the response.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// Metrics Types supported. Enum options - VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY,
        /// CONTROLLER_METRICS_ENTITY, APPLICATION_METRICS_ENTITY, TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metric_entity", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricEntity { get; set; }
        /// <summary>
        /// Order by field in the statistics. It is required tohave include_statistics set to true. A negative sign means decreasing
        /// order. Egs. mean, min, max, etc.
        /// </summary>
        [JsonProperty(PropertyName = "order_series_by")]
        public string? OrderSeriesBy { get; set; }
        /// <summary>
        /// Pad missing health scores. That is, if data for certain intervals not present, fill up the time series with null values.
        /// </summary>
        [JsonProperty(PropertyName = "pad_missing_data")]
        public bool? PadMissingData { get; set; }
        /// <summary>
        /// Patch health score with operational data?.
        /// </summary>
        [JsonProperty(PropertyName = "patch_oper_status")]
        public bool? PatchOperStatus { get; set; }
        /// <summary>
        /// Pool name. This will apply to any backend stats that are specified in the query.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Format of the data returned. Enum options - METRICS_FORMAT_JSON, METRICS_FORMAT_CSV, METRICS_FORMAT_TXT,
        /// METRICS_FORMAT_PROTOBUF.
        /// </summary>
        [JsonProperty(PropertyName = "result_format")]
        public string? ResultFormat { get; set; }
        /// <summary>
        /// Object id like vip or server ip port.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Start time for the metrics in ISO 8601 format. Default is UNIX Epoch.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string? Start { get; set; }
        /// <summary>
        /// Step interval in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public int? Step { get; set; }
        /// <summary>
        /// End time for the metrics in ISO 8601 format. Default is now. Negative numbers mean relative time from now.
        /// </summary>
        [JsonProperty(PropertyName = "stop")]
        public string? Stop { get; set; }
        /// <summary>
        /// Return only summary for health score.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public bool? Summary { get; set; }
        /// <summary>
        /// UUID of the Tenant. .
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
    }
}
