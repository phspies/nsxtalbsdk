using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthScoreTypeContributorDataType
    {
        /// <summary>
        /// Placeholder for description of property entities of obj type HealthScoreTypeContributorData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<NSXTALBHealthScoreEntityType> Entities { get; set; }
        /// <summary>
        /// Enum options - HEALTH_SCORE, HEALTH_PERFORMANCE_SCORE, HEALTH_ANOMALY_SCORE, HEALTH_RESOURCES_SCORE,
        /// HEALTH_SECURITY_THREAT_LEVEL.
        /// </summary>
        [JsonProperty(PropertyName = "hs_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HsType { get; set; }
        /// <summary>
        /// metric_ids of HealthScoreTypeContributorData.
        /// </summary>
        [JsonProperty(PropertyName = "metric_ids")]
        public string? MetricIds { get; set; }
    }
}
