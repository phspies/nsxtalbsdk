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
    public class NSXTALBHealthScorePerformanceDataType 
    {
        /// <summary>
        /// Placeholder for description of property application_performance of obj type HealthScorePerformanceData field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "application_performance")]
        public NSXTALBApplicationPerformanceScoreDataType ApplicationPerformance { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_performance of obj type HealthScorePerformanceData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "pool_performance")]
        public NSXTALBPoolPerformanceScoreDataType PoolPerformance { get; set; }
        /// <summary>
        /// Reason for Performance Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// reason_attr of HealthScorePerformanceData.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// Placeholder for description of property server_performance of obj type HealthScorePerformanceData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_performance")]
        public NSXTALBServerPerformanceScoreDataType ServerPerformance { get; set; }
        /// <summary>
        /// Placeholder for description of property serviceengine_performance of obj type HealthScorePerformanceData field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_performance")]
        public NSXTALBServiceEnginePerformanceScoreDataType ServiceenginePerformance { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type HealthScorePerformanceData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
        /// <summary>
        /// Placeholder for description of property virtualservice_performance of obj type HealthScorePerformanceData field type str
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice_performance")]
        public NSXTALBVirtualServicePerformanceScoreDataType VirtualservicePerformance { get; set; }
    }
}
