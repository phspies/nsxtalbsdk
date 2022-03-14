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
    public class NSXTALBMetricsQueryType 
    {
        /// <summary>
        /// Required if the metrics need to be aggregated across multiple entities like virtualservice.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_entity")]
        public bool? AggregateEntity { get; set; }
        /// <summary>
        /// Aggregate metrics for all the records for obj_id. When this is set obj_id is treated as a filter rather than a
        /// dimension. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "aggregate_obj_id")]
        public bool? AggregateObjId { get; set; }
        /// <summary>
        /// Autonomous System number. Eg. asn=3794.
        /// </summary>
        [JsonProperty(PropertyName = "asn")]
        public string? Asn { get; set; }
        /// <summary>
        /// Dos Attack ID filter.
        /// </summary>
        [JsonProperty(PropertyName = "attack")]
        public string? Attack { get; set; }
        /// <summary>
        /// Browser filter. Eg. browser=Chrome.
        /// </summary>
        [JsonProperty(PropertyName = "browser")]
        public string? Browser { get; set; }
        /// <summary>
        /// Client Insights Source Type - Active or Passive. Enum options - NO_INSIGHTS, PASSIVE, ACTIVE.
        /// </summary>
        [JsonProperty(PropertyName = "client_insights")]
        public string? ClientInsights { get; set; }
        /// <summary>
        /// Two letter country filter. Eg. country=US.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string? Country { get; set; }
        /// <summary>
        /// Detailed header returns metric information, statistics etc. It is has overhead which can be bypassed if caller just
        /// wants raw data.
        /// </summary>
        [JsonProperty(PropertyName = "detailed_header")]
        public bool? DetailedHeader { get; set; }
        /// <summary>
        /// Device type filter. Eg. devtype=desktop.
        /// </summary>
        [JsonProperty(PropertyName = "devtype")]
        public string? Devtype { get; set; }
        /// <summary>
        /// Aggregations for dimensions. Eg. use dimenstion_aggregation=avg for averaged metric values. Enum options -
        /// METRICS_DIMENSION_AGG_NONE, METRICS_DIMENSION_AGG_AVG, METRICS_DIMENSION_AGG_SUM, METRICS_DIMENSION_AGG_MAX,
        /// METRICS_DIMENSION_AGG_MIN, METRICS_DIMENSION_AGG_PERCENT, METRICS_DIMENSION_AGG_ALL.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_aggregation")]
        public string? DimensionAggregation { get; set; }
        /// <summary>
        /// Filters the obj_id based on the filter specified. Enum options - METRICS_FILTER_EQUALS, METRICS_FILTER_LIKE,
        /// METRICS_FILTER_CONTAINS, METRICS_FILTER_NOT_EQUALS.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_filter_op")]
        public string? DimensionFilterOp { get; set; }
        /// <summary>
        /// Limit the number of dimensions in the result. specially useful in case of URLs.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_limit")]
        public int? DimensionLimit { get; set; }
        /// <summary>
        /// Deprecated. perform sampling for dimensional metrics. zero means auto.
        /// </summary>
        [JsonProperty(PropertyName = "dimension_sampling")]
        public int? DimensionSampling { get; set; }
        /// <summary>
        /// Group by dimensions for the metrics. Eg. For results by single dimension use dimensions=browser. For results by browser
        /// and operating system use dimensions=browser,os. Enum options - METRICS_DIMENSION_METRIC_TIMESTAMP,
        /// METRICS_DIMENSION_COUNTRY, METRICS_DIMENSION_OS, METRICS_DIMENSION_URL, METRICS_DIMENSION_DEVTYPE,
        /// METRICS_DIMENSION_LANG, METRICS_DIMENSION_BROWSER, METRICS_DIMENSION_IPGROUP, METRICS_DIMENSION_ATTACK,
        /// METRICS_DIMENSION_ASN.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<string> Dimensions { get; set; }
        /// <summary>
        /// UUID of the entity. Eg. entity_uuid=virtualservice-0-1.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// ID of the request. In case of GET API it is returned in the metrics query response. In case of collections API responses
        /// are grouped byresponses corresponding to each optimized query.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Resolve UUID to names.
        /// </summary>
        [JsonProperty(PropertyName = "include_refs")]
        public bool? IncludeRefs { get; set; }
        /// <summary>
        /// Include metrics statistics with the request.
        /// </summary>
        [JsonProperty(PropertyName = "include_statistics")]
        public bool? IncludeStatistics { get; set; }
        /// <summary>
        /// IPGROUP filter Eg. UUID of the IP group.
        /// </summary>
        [JsonProperty(PropertyName = "ipgroup")]
        public string? Ipgroup { get; set; }
        /// <summary>
        /// Language filter. Eg. lang=english.
        /// </summary>
        [JsonProperty(PropertyName = "lang")]
        public string? Lang { get; set; }
        /// <summary>
        /// Max number of metric samples per metric requestedEg. limit=100 implies return only 100 samples.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// Describes the entity type for which metrics is requested. Eg. &metric_entity=VSERVER_METRICS_ENTITY. Enum options -
        /// VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY, CONTROLLER_METRICS_ENTITY, APPLICATION_METRICS_ENTITY,
        /// TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metric_entity")]
        public string? MetricEntity { get; set; }
        /// <summary>
        /// Comma separated list of metrics requested.Eg. metric_id=l4_client.avg_bandwidth,l7_client.avg_total_responses.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// number of levels of microservices map.
        /// </summary>
        [JsonProperty(PropertyName = "microservice_levels")]
        public int? MicroserviceLevels { get; set; }
        /// <summary>
        /// serverip port of the pool server.
        /// </summary>
        [JsonProperty(PropertyName = "obj_id")]
        public string? ObjId { get; set; }
        /// <summary>
        /// Order metrics series by metric timestamp. -metric_timestamp will result in most recent value first in the time series.
        /// </summary>
        [JsonProperty(PropertyName = "order_by")]
        public string? OrderBy { get; set; }
        /// <summary>
        /// Operating system filter. Eg. os=mac.
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public string? Os { get; set; }
        /// <summary>
        /// Pad missing data when not available.
        /// </summary>
        [JsonProperty(PropertyName = "pad_missing_data")]
        public bool? PadMissingData { get; set; }
        /// <summary>
        /// page id for the query. Allowed only for aggregation queries.
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public int? Page { get; set; }
        /// <summary>
        /// page size of the query. Allowed only for the aggregation queries.
        /// </summary>
        [JsonProperty(PropertyName = "page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// metrics for a member pool in a virtual service.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Request prediction values instead of actual observed metrics in future if supported.
        /// </summary>
        [JsonProperty(PropertyName = "prediction")]
        public bool? Prediction { get; set; }
        /// <summary>
        /// Deprecated. Please do not use this option. APIs only support JSON format. Enum options - METRICS_FORMAT_JSON,
        /// METRICS_FORMAT_CSV, METRICS_FORMAT_TXT, METRICS_FORMAT_PROTOBUF.
        /// </summary>
        [JsonProperty(PropertyName = "result_format")]
        public string? ResultFormat { get; set; }
        /// <summary>
        /// Deprecated. Enum options - METRICS_SAMPLING_DEFAULT, METRICS_SAMPLING_FAST, METRICS_SAMPLING_FORCE.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_level")]
        public string? SamplingLevel { get; set; }
        /// <summary>
        /// Pool Server ID in format server IP port. Eg. 10.10.1.42 80.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// UUID of the service engine.Eg. serviceengine_uuid=se-422ce810-50a4-2ecd-d45d-870656e99b7b.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_uuid")]
        public string? ServiceengineUuid { get; set; }
        /// <summary>
        /// Start time for the metrics in ISO 8601 format. Default is UNIX Epoch. Eg. start=1970-01-01T00 00 00.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string? Start { get; set; }
        /// <summary>
        /// Metrics time series returned with time points every time duration specified as step. Eg. if bandwidth is desired every 5
        /// Secs then use step=5&metric_id=l4_client.avg_bandwidth.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public int? Step { get; set; }
        /// <summary>
        /// End time for the metrics in ISO 8601 format. Default is now. Eg. stop=2014-01-01T12 42 42.
        /// </summary>
        [JsonProperty(PropertyName = "stop")]
        public string? Stop { get; set; }
        /// <summary>
        /// UUID of the Tenant. .
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// URL filter. Eg. url=http //www.avinetworks.com.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Validate every data before returning. This will result in increased latency and should only be used for troubleshooting.
        /// </summary>
        [JsonProperty(PropertyName = "validate_data")]
        public bool? ValidateData { get; set; }
    }
}
