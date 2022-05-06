using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthScoreDataSeriesType
    {
        /// <summary>
        /// Placeholder for description of property data of obj type HealthScoreDataSeries field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<NSXTALBHealthScoreDataType> Data { get; set; }
        /// <summary>
        /// Placeholder for description of property header of obj type HealthScoreDataSeries field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBHealthScoreHeaderType Header { get; set; }
    }
}
