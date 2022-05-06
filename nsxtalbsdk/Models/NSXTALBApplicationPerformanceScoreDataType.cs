using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBApplicationPerformanceScoreDataType
    {
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type Application.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property virtualservice_performance_scores of obj type ApplicationPerformanceScoreData
        /// field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice_performance_scores")]
        public IList<NSXTALBVirtualServicePerformanceScoreType> VirtualservicePerformanceScores { get; set; }
    }
}
