using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceEngineAnomalyScoreType
    {
        /// <summary>
        /// Placeholder for description of property hs_entity of obj type ServiceEngineAnomalyScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_entity")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBHealthScoreEntityType HsEntity { get; set; }
        /// <summary>
        /// reason of ServiceEngineAnomalyScore.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property score_data of obj type ServiceEngineAnomalyScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "score_data")]
        public NSXTALBServiceEngineAnomalyScoreDataType ScoreData { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type ServiceEngineAnomalyScore field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
