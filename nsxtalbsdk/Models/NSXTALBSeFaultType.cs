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
    public class NSXTALBSeFaultType 
    {
        /// <summary>
        /// Optional 64 bit unsigned integer that can be used within the enabled fault. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "arg")]
        public long? Arg { get; set; }
        /// <summary>
        /// The name of the target fault. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "fault_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FaultName { get; set; }
        /// <summary>
        /// The name of the function that contains the target fault. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "function_name")]
        public string? FunctionName { get; set; }
        /// <summary>
        /// Number of times the fault should be executed. Allowed values are 1-4294967295. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_executions")]
        public int? NumExecutions { get; set; }
        /// <summary>
        /// Number of times the fault should be skipped before executing. Field introduced in 18.2.9.
        /// </summary>
        [JsonProperty(PropertyName = "num_skips")]
        public int? NumSkips { get; set; }
    }
}
