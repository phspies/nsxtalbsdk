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
    public class NSXTALBSeMemoryLimitEventDetailsType 
    {
        public NSXTALBSeMemoryLimitEventDetailsType()
        {
        }
        /// <summary>
        /// Current status of config memory. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "config_memory_status")]
        public string? ConfigMemoryStatus { get; set; }
        /// <summary>
        /// Heap config memory hard limit. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "heap_config_hard_limit")]
        public int? HeapConfigHardLimit { get; set; }
        /// <summary>
        /// Heap config memory soft limit. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "heap_config_soft_limit")]
        public int? HeapConfigSoftLimit { get; set; }
        /// <summary>
        /// Config memory usage in heap memory. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "heap_config_usage")]
        public int? HeapConfigUsage { get; set; }
        /// <summary>
        /// Connection memory usage in heap memory. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "heap_conn_usage")]
        public int? HeapConnUsage { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine. Field introduced in
        /// 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// Current shm config memory hard limit. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "shm_config_hard_limit")]
        public int? ShmConfigHardLimit { get; set; }
        /// <summary>
        /// Current shm config memory soft limit. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "shm_config_soft_limit")]
        public int? ShmConfigSoftLimit { get; set; }
        /// <summary>
        /// Config memory usage in shared memory. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "shm_config_usage")]
        public int? ShmConfigUsage { get; set; }
        /// <summary>
        /// Connection memory usage in shared memory. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "shm_conn_usage")]
        public int? ShmConnUsage { get; set; }
    }
}
