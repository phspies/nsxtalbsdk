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
    public class NSXTALBMetricsMissingDataIntervalType 
    {
        /// <summary>
        /// end of MetricsMissingDataInterval.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string End { get; set; }
        /// <summary>
        /// start of MetricsMissingDataInterval.
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Start { get; set; }
    }
}
