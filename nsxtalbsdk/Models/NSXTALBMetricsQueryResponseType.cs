using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBMetricsQueryResponseType
    {
        /// <summary>
        /// Unique object identifier of entity.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// returns the ID specified in the query.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Number of limit.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// Enum options - VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY, CONTROLLER_METRICS_ENTITY,
        /// APPLICATION_METRICS_ENTITY, TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metric_entity")]
        public string? MetricEntity { get; set; }
        /// <summary>
        /// metric_id of MetricsQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// Placeholder for description of property series of obj type MetricsQueryResponse field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "series")]
        public IList<NSXTALBMetricsDataSeriesType> Series { get; set; }
        /// <summary>
        /// start of MetricsQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public string? Start { get; set; }
        /// <summary>
        /// Number of step.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public int? Step { get; set; }
        /// <summary>
        /// stop of MetricsQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "stop")]
        public string? Stop { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
    }
}
