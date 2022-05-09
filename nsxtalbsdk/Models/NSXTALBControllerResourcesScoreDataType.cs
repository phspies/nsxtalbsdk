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
    public class NSXTALBControllerResourcesScoreDataType 
    {
        /// <summary>
        /// Placeholder for description of property avg_cpu_usage of obj type ControllerResourcesScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_usage")]
        public double? AvgCpuUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_mem_usage of obj type ControllerResourcesScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_mem_usage")]
        public double? AvgMemUsage { get; set; }
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
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
