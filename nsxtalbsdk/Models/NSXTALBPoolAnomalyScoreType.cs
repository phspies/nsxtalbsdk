using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPoolAnomalyScoreType
    {
        /// <summary>
        /// Placeholder for description of property hs_entity of obj type PoolAnomalyScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_entity")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBHealthScoreEntityType HsEntity { get; set; }
        /// <summary>
        /// reason of PoolAnomalyScore.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property score_data of obj type PoolAnomalyScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "score_data")]
        public NSXTALBPoolAnomalyScoreDataType ScoreData { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type PoolAnomalyScore field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
