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
    public class NSXTALBHealthScoreHeaderType 
    {
        /// <summary>
        /// Placeholder for description of property anomaly_penalty_statistics of obj type HealthScoreHeader field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "anomaly_penalty_statistics")]
        public NSXTALBMetricStatisticsType AnomalyPenaltyStatistics { get; set; }
        /// <summary>
        /// Placeholder for description of property contributors of obj type HealthScoreHeader field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "contributors")]
        public IList<NSXTALBHealthScoreTypeContributorDataType> Contributors { get; set; }
        /// <summary>
        /// uuid of the entity type.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// Enum options - HEALTH_SCORE, HEALTH_PERFORMANCE_SCORE, HEALTH_ANOMALY_SCORE, HEALTH_RESOURCES_SCORE,
        /// HEALTH_SECURITY_THREAT_LEVEL.
        /// </summary>
        [JsonProperty(PropertyName = "hs_type")]
        public string? HsType { get; set; }
        /// <summary>
        /// Number of metrics_min_scale.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_min_scale")]
        public int? MetricsMinScale { get; set; }
        /// <summary>
        /// Missing data intervals. data in these intervals are not used for stats calculation.
        /// </summary>
        [JsonProperty(PropertyName = "missing_intervals")]
        public IList<NSXTALBMetricsMissingDataIntervalType> MissingIntervals { get; set; }
        /// <summary>
        /// Health Score metric name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property performance_score_statistics of obj type HealthScoreHeader field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "performance_score_statistics")]
        public NSXTALBMetricStatisticsType PerformanceScoreStatistics { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        public string? PoolRef { get; set; }
        /// <summary>
        /// Placeholder for description of property resources_penalty_statistics of obj type HealthScoreHeader field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "resources_penalty_statistics")]
        public NSXTALBMetricStatisticsType ResourcesPenaltyStatistics { get; set; }
        /// <summary>
        /// Placeholder for description of property security_penalty_statistics of obj type HealthScoreHeader field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "security_penalty_statistics")]
        public NSXTALBMetricStatisticsType SecurityPenaltyStatistics { get; set; }
        /// <summary>
        /// server of HealthScoreHeader.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_ref")]
        public string? ServiceengineRef { get; set; }
        /// <summary>
        /// Placeholder for description of property statistics of obj type HealthScoreHeader field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTALBMetricStatisticsType Statistics { get; set; }
        /// <summary>
        /// units of the column data. Enum options - METRIC_COUNT, BITS_PER_SECOND, MILLISECONDS, SECONDS, PER_SECOND, BYTES,
        /// PERCENT, KILO_BYTES, KILO_BYTES_PER_SECOND, BYTES_PER_SECOND, KILO_BITS_PER_SECOND, GIGA_BYTES, MEGA_BYTES, NORMALIZED,
        /// STRING, SEC, MIN, DAYS, KB, MB, GB, MBPS, GHZ, RATIO, WORD, MICROSECONDS, HEALTH, HOURS.
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public string? Units { get; set; }
    }
}
