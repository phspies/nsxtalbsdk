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
    public class NSXTALBRelationalOperatorsParamsType 
    {
        public NSXTALBRelationalOperatorsParamsType()
        {
        }
        /// <summary>
        /// Unique object identifier of entity.
        /// </summary>
        [JsonProperty(PropertyName = "entity_uuid")]
        public string? EntityUuid { get; set; }
        /// <summary>
        /// metric_id of RelationalOperatorsParams.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MetricId { get; set; }
        /// <summary>
        /// right_arg of RelationalOperatorsParams.
        /// </summary>
        [JsonProperty(PropertyName = "right_arg", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string RightArg { get; set; }
    }
}
