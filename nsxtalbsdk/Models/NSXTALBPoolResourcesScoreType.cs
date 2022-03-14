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
    public class NSXTALBPoolResourcesScoreType 
    {
        public NSXTALBPoolResourcesScoreType()
        {
        }
        /// <summary>
        /// Placeholder for description of property hs_entity of obj type PoolResourcesScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_entity", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBHealthScoreEntityType HsEntity { get; set; }
        /// <summary>
        /// reason of PoolResourcesScore.
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property score_data of obj type PoolResourcesScore field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "score_data")]
        public NSXTALBPoolResourcesScoreDataType ScoreData { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type PoolResourcesScore field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
    }
}
