using Newtonsoft.Json;
using System.Linq;
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
        [JsonProperty(PropertyName = "op")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Op { get; set; }
        /// <summary>
        /// Placeholder for description of property rel_param of obj type MetricsFilters field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "rel_param")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBRelationalOperatorsParamsType RelParam { get; set; }
    }
}
