using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServerAnomalyScoreType
    {
        /// <summary>
        /// Placeholder for description of property hs_entity of obj type ServerAnomalyScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_entity")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBHealthScoreEntityType HsEntity { get; set; }
        /// <summary>
        /// reason of ServerAnomalyScore.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property score_data of obj type ServerAnomalyScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "score_data")]
        public NSXTALBServerAnomalyScoreDataType ScoreData { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type ServerAnomalyScore field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
