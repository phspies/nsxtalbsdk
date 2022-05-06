using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPoolResourcesScoreDataType
    {
        /// <summary>
        /// Placeholder for description of property avg_server_resources_score of obj type PoolResourcesScoreData field type str 
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_server_resources_score")]
        public double? AvgServerResourcesScore { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_uptime of obj type PoolResourcesScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_uptime")]
        public double? AvgUptime { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolRef { get; set; }
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property server_resources_scores of obj type PoolResourcesScoreData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_resources_scores")]
        public IList<NSXTALBServerResourcesScoreType> ServerResourcesScores { get; set; }
    }
}
