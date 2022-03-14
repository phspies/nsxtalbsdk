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
    public class NSXTALBMemoryBalancerInfoType 
    {
        public NSXTALBMemoryBalancerInfoType()
        {
        }
        /// <summary>
        /// Child process information.
        /// </summary>
        [JsonProperty(PropertyName = "child")]
        public IList<NSXTALBChildProcessInfoType> Child { get; set; }
        /// <summary>
        /// Current controller memory (in GB) usage.
        /// </summary>
        [JsonProperty(PropertyName = "controller_memory")]
        public int? ControllerMemory { get; set; }
        /// <summary>
        /// Percent usage of total controller memory. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_memory_usage_percent")]
        public double? ControllerMemoryUsagePercent { get; set; }
        /// <summary>
        /// Holder for debug message. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "debug_message")]
        public string? DebugMessage { get; set; }
        /// <summary>
        /// Limit on the memory (in KB) for the Process.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// Amount of memory (in KB) used by the Process.
        /// </summary>
        [JsonProperty(PropertyName = "memory_used")]
        public int? MemoryUsed { get; set; }
        /// <summary>
        /// PID of the Process.
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public int? Pid { get; set; }
        /// <summary>
        /// Name of the Process.
        /// </summary>
        [JsonProperty(PropertyName = "process")]
        public string? Process { get; set; }
        /// <summary>
        /// Current mode of the process. Enum options - REGULAR, DEBUG, DEGRADED, STOP. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "process_mode")]
        public string? ProcessMode { get; set; }
        /// <summary>
        /// Current usage trend of the process. Enum options - UPWARD, DOWNWARD, NEUTRAL. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "process_trend")]
        public string? ProcessTrend { get; set; }
        /// <summary>
        /// Percent usage of the process limit. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "threshold_percent")]
        public double? ThresholdPercent { get; set; }
    }
}
