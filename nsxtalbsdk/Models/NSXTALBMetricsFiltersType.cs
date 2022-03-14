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
    public class NSXTALBMetricsFiltersType 
    {
        /// <summary>
        /// Enum options - EQ, GT, GE, LT, LE, NE.
        /// </summary>
        [JsonProperty(PropertyName = "op", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Op { get; set; }
        /// <summary>
        /// Placeholder for description of property rel_param of obj type MetricsFilters field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rel_param", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRelationalOperatorsParamsType RelParam { get; set; }
    }
}
