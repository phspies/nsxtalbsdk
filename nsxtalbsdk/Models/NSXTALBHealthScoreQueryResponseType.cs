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
    public class NSXTALBHealthScoreQueryResponseType 
    {
        /// <summary>
        /// uuid of the entity type.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string EntityUuid { get; set; }
        /// <summary>
        /// Enum options - VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY, CONTROLLER_METRICS_ENTITY,
        /// APPLICATION_METRICS_ENTITY, TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metric_entity")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricEntity { get; set; }
        /// <summary>
        /// Pool name. This will apply to any back end statistics that are specified in the query. It is a reference to an object of
        /// type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// Placeholder for description of property series of obj type HealthScoreQueryResponse field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "series")]
        public IList<NSXTALBHealthScoreDataSeriesType> Series { get; set; }
        /// <summary>
        /// server name or ip.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// start of HealthScoreQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Start { get; set; }
        /// <summary>
        /// Number of step.
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Step { get; set; }
        /// <summary>
        /// stop of HealthScoreQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "stop")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Stop { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
    }
}
