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
    public class NSXTALBHealthScoreEntityType 
    {
        /// <summary>
        /// Unique object identifier of entity.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string EntityUuid { get; set; }
        /// <summary>
        /// Enum options - VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY, CONTROLLER_METRICS_ENTITY,
        /// APPLICATION_METRICS_ENTITY, TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_entity", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricsEntity { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// server of HealthScoreEntity.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
    }
}
