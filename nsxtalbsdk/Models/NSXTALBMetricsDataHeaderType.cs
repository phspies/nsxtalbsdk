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
    public class NSXTALBMetricsDataHeaderType 
    {
        /// <summary>
        /// Metrics derivation info.
        /// </summary>
        [JsonProperty(PropertyName = "derivation_data")]
        public NSXTALBMetricsDerivationDataType DerivationData { get; set; }
        /// <summary>
        /// Placeholder for description of property dimension_data of obj type MetricsDataHeader field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "dimension_data")]
        public IList<NSXTALBMetricsDimensionDataType> DimensionData { get; set; }
        /// <summary>
        /// entity uuid.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// metric_description of MetricsDataHeader.
        /// </summary>
        [JsonProperty(PropertyName = "metric_description")]
        public string? MetricDescription { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_min_scale of obj type MetricsDataHeader field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "metrics_min_scale")]
        public double? MetricsMinScale { get; set; }
        /// <summary>
        /// Placeholder for description of property metrics_sum_agg_invalid of obj type MetricsDataHeader field type str  type
        /// boolean
        /// </summary>
        [JsonProperty(PropertyName = "metrics_sum_agg_invalid")]
        public bool? MetricsSumAggInvalid { get; set; }
        /// <summary>
        /// Missing data intervals. data in these intervals are not used for stats calculation.
        /// </summary>
        [JsonProperty(PropertyName = "missing_intervals")]
        public IList<NSXTALBMetricsMissingDataIntervalType> MissingIntervals { get; set; }
        /// <summary>
        /// name of the column.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// object ID of the series when object ID was specified in the metric.
        /// </summary>
        [JsonProperty(PropertyName = "obj_id")]
        public string? ObjId { get; set; }
        /// <summary>
        /// obj_id_type. Enum options - METRICS_OBJ_ID_TYPE_VIRTUALSERVICE, METRICS_OBJ_ID_TYPE_SERVER, METRICS_OBJ_ID_TYPE_POOL,
        /// METRICS_OBJ_ID_TYPE_SERVICEENGINE, METRICS_OBJ_ID_TYPE_VIRTUALMACHINE, METRICS_OBJ_ID_TYPE_CONTROLLER,
        /// METRICS_OBJ_ID_TYPE_TENANT, METRICS_OBJ_ID_TYPE_CLUSTER, METRICS_OBJ_ID_TYPE_SE_INTERFACE.
        /// </summary>
        [JsonProperty(PropertyName = "obj_id_type")]
        public string? ObjIdType { get; set; }
        /// <summary>
        /// pool_id for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property priority of obj type MetricsDataHeader field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public bool? Priority { get; set; }
        /// <summary>
        /// server ip port.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Service Engine ref or UUID. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_uuid")]
        public string? ServiceengineUuid { get; set; }
        /// <summary>
        /// statistics of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTALBMetricStatisticsType Statistics { get; set; }
        /// <summary>
        /// Tenant ref or UUID.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// units of the column data. Enum options - METRIC_COUNT, BITS_PER_SECOND, MILLISECONDS, SECONDS, PER_SECOND, BYTES,
        /// PERCENT, KILO_BYTES, KILO_BYTES_PER_SECOND, BYTES_PER_SECOND, KILO_BITS_PER_SECOND, GIGA_BYTES, MEGA_BYTES, NORMALIZED,
        /// STRING, SEC, MIN, DAYS, KB, MB, GB, MBPS, GHZ, RATIO, WORD, MICROSECONDS, HEALTH, HOURS.
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public string? Units { get; set; }
    }
}
