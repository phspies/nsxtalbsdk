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
    public class NSXTALBServiceEngineResourcesScoreDataType 
    {
        /// <summary>
        /// Placeholder for description of property avg_connection_mem_usage of obj type ServiceEngineResourcesScoreData field type
        /// str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_connection_mem_usage")]
        public double? AvgConnectionMemUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_cpu_usage of obj type ServiceEngineResourcesScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_usage")]
        public double? AvgCpuUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_cpu_wait of obj type ServiceEngineResourcesScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_cpu_wait")]
        public double? AvgCpuWait { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_disk1_usage of obj type ServiceEngineResourcesScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_disk1_usage")]
        public double? AvgDisk1Usage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_dynamic_mem_usage of obj type ServiceEngineResourcesScoreData field type str
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_dynamic_mem_usage")]
        public double? AvgDynamicMemUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_mem_usage of obj type ServiceEngineResourcesScoreData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_mem_usage")]
        public double? AvgMemUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_packet_buffer_usage of obj type ServiceEngineResourcesScoreData field type
        /// str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_packet_buffer_usage")]
        public double? AvgPacketBufferUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_persistent_table_usage of obj type ServiceEngineResourcesScoreData field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_persistent_table_usage")]
        public double? AvgPersistentTableUsage { get; set; }
        /// <summary>
        /// Use shared memory usage in computation of SE resource penalty.
        /// </summary>
        [JsonProperty(PropertyName = "avg_shared_memory_usage")]
        public double? AvgSharedMemoryUsage { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_ssl_session_cache_usage of obj type ServiceEngineResourcesScoreData field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_ssl_session_cache_usage")]
        public double? AvgSslSessionCacheUsage { get; set; }
        /// <summary>
        /// Enum options - OPER_UP, OPER_DOWN, OPER_CREATING, OPER_RESOURCES, OPER_INACTIVE, OPER_DISABLED, OPER_UNUSED,
        /// OPER_UNKNOWN, OPER_PROCESSING, OPER_INITIALIZING, OPER_ERROR_DISABLED, OPER_AWAIT_MANUAL_PLACEMENT, OPER_UPGRADING,
        /// OPER_SE_PROCESSING, OPER_PARTITIONED, OPER_DISABLING, OPER_FAILED, OPER_UNAVAIL.
        /// </summary>
        [JsonProperty(PropertyName = "oper_state")]
        public string? OperState { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_syn_cache_usage of obj type ServiceEngineResourcesScoreData field type str 
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_syn_cache_usage")]
        public double? PctSynCacheUsage { get; set; }
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
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
    }
}
