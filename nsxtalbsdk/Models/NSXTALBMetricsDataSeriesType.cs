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
    public class NSXTALBMetricsDataSeriesType 
    {
        /// <summary>
        /// Placeholder for description of property data of obj type MetricsDataSeries field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<NSXTALBMetricsDataType> Data { get; set; }
        /// <summary>
        /// Placeholder for description of property header of obj type MetricsDataSeries field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "header")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBMetricsDataHeaderType Header { get; set; }
    }
}
