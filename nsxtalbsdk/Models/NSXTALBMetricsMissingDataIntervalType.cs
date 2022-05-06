using Newtonsoft.Json;
using System.Linq;
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
        [JsonProperty(PropertyName = "end")]
        [System.ComponentModel.DataAnnotations.Required]
        public string End { get; set; }
        /// <summary>
        /// start of MetricsMissingDataInterval.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Start { get; set; }
    }
}
