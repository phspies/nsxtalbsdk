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
    public class NSXTALBAnomalyDataType 
    {
        public NSXTALBAnomalyDataType()
        {
        }
        /// <summary>
        /// Placeholder for description of property anomaly_context of obj type AnomalyData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_context")]
        public NSXTALBAnomalyContextType AnomalyContext { get; set; }
        /// <summary>
        /// Deprecated. Enum options - EXPONENTIAL_MOVING_AVG, EXPONENTIAL_WEIGHTED_MOVING_AVG, HOLTWINTERS_AT_AS,
        /// HOLTWINTERS_AT_MS.
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_model")]
        public string? AnomalyModel { get; set; }
        /// <summary>
        /// Unique object identifier of entity.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// obj_id of AnomalyData.
        /// </summary>
        [JsonProperty(PropertyName = "obj_id")]
        public string? ObjId { get; set; }
        /// <summary>
        /// Object ID type. Enum options - METRICS_OBJ_ID_TYPE_VIRTUALSERVICE, METRICS_OBJ_ID_TYPE_SERVER, METRICS_OBJ_ID_TYPE_POOL,
        /// METRICS_OBJ_ID_TYPE_SERVICEENGINE, METRICS_OBJ_ID_TYPE_VIRTUALMACHINE, METRICS_OBJ_ID_TYPE_CONTROLLER,
        /// METRICS_OBJ_ID_TYPE_TENANT, METRICS_OBJ_ID_TYPE_CLUSTER, METRICS_OBJ_ID_TYPE_SE_INTERFACE.
        /// </summary>
        [JsonProperty(PropertyName = "obj_id_type")]
        public string? ObjIdType { get; set; }
        /// <summary>
        /// Unique object identifier of pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Enum options - ANZ_PRIORITY_HIGH, ANZ_PRIORITY_MEDIUM, ANZ_PRIORITY_LOW.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public string? Priority { get; set; }
        /// <summary>
        /// timestamp of AnomalyData.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Timestamp { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type AnomalyData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
