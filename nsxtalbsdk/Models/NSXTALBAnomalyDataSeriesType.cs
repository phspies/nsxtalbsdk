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
    public class NSXTALBAnomalyDataSeriesType 
    {
        /// <summary>
        /// Placeholder for description of property data of obj type AnomalyDataSeries field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<NSXTALBAnomalyDataType> Data { get; set; }
        /// <summary>
        /// Placeholder for description of property header of obj type AnomalyDataSeries field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "header", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBMetricsDataHeaderType Header { get; set; }
    }
}
