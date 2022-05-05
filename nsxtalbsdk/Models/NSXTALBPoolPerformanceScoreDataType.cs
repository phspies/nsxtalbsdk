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
    public class NSXTALBPoolPerformanceScoreDataType 
    {
        /// <summary>
        /// Placeholder for description of property apdexc of obj type PoolPerformanceScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "apdexc")]
        public double? Apdexc { get; set; }
        /// <summary>
        /// Placeholder for description of property apdexr of obj type PoolPerformanceScoreData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "apdexr")]
        public double? Apdexr { get; set; }
        /// <summary>
        /// Enum options - OPER_UP, OPER_DOWN, OPER_CREATING, OPER_RESOURCES, OPER_INACTIVE, OPER_DISABLED, OPER_UNUSED,
        /// OPER_UNKNOWN, OPER_PROCESSING, OPER_INITIALIZING, OPER_ERROR_DISABLED, OPER_AWAIT_MANUAL_PLACEMENT, OPER_UPGRADING,
        /// OPER_SE_PROCESSING, OPER_PARTITIONED, OPER_DISABLING, OPER_FAILED, OPER_UNAVAIL.
        /// </summary>
        [JsonProperty(PropertyName = "oper_state")]
        public string? OperState { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PoolRef { get; set; }
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
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property sum_finished_conns of obj type PoolPerformanceScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "sum_finished_conns")]
        public double? SumFinishedConns { get; set; }
    }
}
