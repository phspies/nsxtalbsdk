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
    public class NSXTALBVirtualServicePerformanceScoreDataType 
    {
        public NSXTALBVirtualServicePerformanceScoreDataType()
        {
        }
        /// <summary>
        /// Placeholder for description of property apdexc of obj type VirtualServicePerformanceScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "apdexc")]
        public double? Apdexc { get; set; }
        /// <summary>
        /// Placeholder for description of property apdexr of obj type VirtualServicePerformanceScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "apdexr")]
        public double? Apdexr { get; set; }
        /// <summary>
        /// Average of all pool performance scores.
        /// </summary>
        [JsonProperty(PropertyName = "avg_pool_performance_score")]
        public double? AvgPoolPerformanceScore { get; set; }
        /// <summary>
        /// Enum options - OPER_UP, OPER_DOWN, OPER_CREATING, OPER_RESOURCES, OPER_INACTIVE, OPER_DISABLED, OPER_UNUSED,
        /// OPER_UNKNOWN, OPER_PROCESSING, OPER_INITIALIZING, OPER_ERROR_DISABLED, OPER_AWAIT_MANUAL_PLACEMENT, OPER_UPGRADING,
        /// OPER_SE_PROCESSING, OPER_PARTITIONED, OPER_DISABLING, OPER_FAILED, OPER_UNAVAIL.
        /// </summary>
        [JsonProperty(PropertyName = "oper_state", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string OperState { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_performance_scores of obj type VirtualServicePerformanceScoreData field
        /// type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_performance_scores")]
        public IList<NSXTALBPoolPerformanceScoreType> PoolPerformanceScores { get; set; }
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Rum Apdexr when client insights is active.
        /// </summary>
        [JsonProperty(PropertyName = "rum_apdexr")]
        public double? RumApdexr { get; set; }
        /// <summary>
        /// Placeholder for description of property sum_finished_conns of obj type VirtualServicePerformanceScoreData field type str
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "sum_finished_conns")]
        public double? SumFinishedConns { get; set; }
        /// <summary>
        /// Percentage time of last 5mins that the VirtualService has been up.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uptime")]
        public double? VsUptime { get; set; }
    }
}
