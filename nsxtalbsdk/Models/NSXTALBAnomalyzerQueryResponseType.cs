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
    public class NSXTALBAnomalyzerQueryResponseType 
    {
        public NSXTALBAnomalyzerQueryResponseType()
        {
        }
        /// <summary>
        /// metric_id of AnomalyzerQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
        /// <summary>
        /// Placeholder for description of property series of obj type AnomalyzerQueryResponse field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "series")]
        public IList<NSXTALBAnomalyDataSeriesType> Series { get; set; }
        /// <summary>
        /// start of AnomalyzerQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Start { get; set; }
        /// <summary>
        /// Number of step.
        /// </summary>
        [JsonProperty(PropertyName = "step", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Step { get; set; }
        /// <summary>
        /// stop of AnomalyzerQueryResponse.
        /// </summary>
        [JsonProperty(PropertyName = "stop", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Stop { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
    }
}
