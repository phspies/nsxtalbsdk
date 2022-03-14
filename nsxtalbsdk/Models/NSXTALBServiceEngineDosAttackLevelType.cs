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
    public class NSXTALBServiceEngineDosAttackLevelType 
    {
        /// <summary>
        /// Placeholder for description of property hs_entity of obj type ServiceEngineDosAttackLevel field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "hs_entity")]
        public NSXTALBHealthScoreEntityType HsEntity { get; set; }
        /// <summary>
        /// reason of ServiceEngineDosAttackLevel.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Placeholder for description of property score_data of obj type ServiceEngineDosAttackLevel field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "score_data")]
        public NSXTALBServiceEngineDosAttackLevelDataType ScoreData { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type ServiceEngineDosAttackLevel field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }
    }
}
