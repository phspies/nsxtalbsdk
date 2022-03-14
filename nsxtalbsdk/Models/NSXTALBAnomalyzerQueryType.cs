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
    public class NSXTALBAnomalyzerQueryType 
    {
        public NSXTALBAnomalyzerQueryType()
        {
        }
        /// <summary>
        /// Aggregate metrics for all the records for obj_id. When this is set obj_id is treated as a filter rather than a
        /// dimension. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_obj_id")]
        public bool? AggregateObjId { get; set; }
        /// <summary>
        /// Enum options - METRICS_ANOMALY_AGG_NONE, METRICS_ANOMALY_AGG_COUNT.
        /// </summary>
        [JsonProperty(PropertyName = "aggregation")]
        public string? Aggregation { get; set; }
        /// <summary>
        /// factor of aggregation window to the step. Eg. if requirement to is aggregate count ever 30 mins using 5 minute samples
        /// then value is 6.
        /// </summary>
        [JsonProperty(PropertyName = "aggregation_window")]
        public int? AggregationWindow { get; set; }
        /// <summary>
        /// ability to reduce the information returned in header.
        /// </summary>
        [JsonProperty(PropertyName = "detailed_header")]
        public bool? DetailedHeader { get; set; }
        /// <summary>
        /// Filters the obj_id based on the filter specified. Enum options - METRICS_FILTER_EQUALS, METRICS_FILTER_LIKE,
        /// METRICS_FILTER_CONTAINS, METRICS_FILTER_NOT_EQUALS.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_filter_op")]
        public string? DimensionFilterOp { get; set; }
        /// <summary>
        /// uuid of the entity type.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string EntityUuid { get; set; }
        /// <summary>
        /// Resolve uuid to references.
        /// </summary>
        [JsonProperty(PropertyName = "include_refs")]
        public bool? IncludeRefs { get; set; }
        /// <summary>
        /// include anomalies from related objects.
        /// </summary>
        [JsonProperty(PropertyName = "include_related")]
        public bool? IncludeRelated { get; set; }
        /// <summary>
        /// Max number of metric samples.
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
        /// This is of the form l4_server. comma seperated values.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// Enum options - EXPONENTIAL_MOVING_AVG, EXPONENTIAL_WEIGHTED_MOVING_AVG, HOLTWINTERS_AT_AS, HOLTWINTERS_AT_MS.
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string? Model { get; set; }
        /// <summary>
        /// object id like vip or server ip.
        /// </summary>
        [JsonProperty(PropertyName = "obj_id")]
        public string? ObjId { get; set; }
        /// <summary>
        /// Positive means sort from start and Negative sign means sort from end. Only metric_timestamp is supported for now.
        /// </summary>
        [JsonProperty(PropertyName = "order_by")]
        public string? OrderBy { get; set; }
        /// <summary>
        /// page id for the anomaly query.
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }
        /// <summary>
        /// size of each page of anomalies.
        /// </summary>
        [JsonProperty(PropertyName = "page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// Pool name. This will apply to any backend stats that are specified in the query.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// High priority Anomaly. Enum options - ANZ_PRIORITY_HIGH, ANZ_PRIORITY_MEDIUM, ANZ_PRIORITY_LOW.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public string? Priority { get; set; }
        /// <summary>
        /// format of the data returned. Enum options - METRICS_FORMAT_JSON, METRICS_FORMAT_CSV, METRICS_FORMAT_TXT,
        /// METRICS_FORMAT_PROTOBUF.
        /// </summary>
        [JsonProperty(PropertyName = "result_format")]
        public string? ResultFormat { get; set; }
        /// <summary>
        /// server ip port.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// ID of the Node. Eg. if query is SE specific then it would have SE UUID.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_uuid")]
        public string? ServiceengineUuid { get; set; }
        /// <summary>
        /// Start time for the metrics in ISO 8601 format. Default is UNIX Epoch.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string? Start { get; set; }
        /// <summary>
        /// step interval in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public int? Step { get; set; }
        /// <summary>
        /// End time for the metrics in ISO 8601 format. Default is now. Negative numbers mean relative time from now.
        /// </summary>
        [JsonProperty(PropertyName = "stop")]
        public string? Stop { get; set; }
        /// <summary>
        /// UUID of the Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
    }
}
