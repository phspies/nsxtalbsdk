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
    public class NSXTALBProcessInfoType 
    {
        public NSXTALBProcessInfoType()
        {
        }
        /// <summary>
        /// Current Process ID. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "current_process_id")]
        public double? CurrentProcessId { get; set; }
        /// <summary>
        /// Total memory usage of process in KBs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "current_process_mem_usage")]
        public double? CurrentProcessMemUsage { get; set; }
        /// <summary>
        /// Number of times the process has been in current ProcessMode. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "intimation_count")]
        public double? IntimationCount { get; set; }
        /// <summary>
        /// Memory limit for process in KBs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "memory_limit")]
        public double? MemoryLimit { get; set; }
        /// <summary>
        /// Current usage trend of process memory. Enum options - UPWARD, DOWNWARD, NEUTRAL. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "memory_trend_usage")]
        public string? MemoryTrendUsage { get; set; }
        /// <summary>
        /// Current mode of process. Enum options - REGULAR, DEBUG, DEGRADED, STOP. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "process_mode")]
        public string? ProcessMode { get; set; }
        /// <summary>
        /// Percentage of memory used out of given limits. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "threshold_percent")]
        public double? ThresholdPercent { get; set; }
    }
}
