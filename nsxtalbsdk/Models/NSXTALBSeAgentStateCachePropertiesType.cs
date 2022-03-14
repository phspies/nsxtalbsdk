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
    public class NSXTALBSeAgentStateCachePropertiesType 
    {
        /// <summary>
        /// Max elements to flush in one shot from the internal buffer by the statecache thread. Allowed values are 1-10000. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sc_batch_buffer_flush_limit")]
        public int? ScBatchBufferFlushLimit { get; set; }
        /// <summary>
        /// Max elements to dequeue in one shot from the Q by the statecache thread. Allowed values are 1-10000. Field introduced in
        /// 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sc_cfg_q_batch_dequeue_limit")]
        public int? ScCfgQBatchDequeueLimit { get; set; }
        /// <summary>
        /// Max elements in the config queue between seagent main and the statecache thread. Allowed values are 1-10000. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sc_cfg_q_max_size")]
        public int? ScCfgQMaxSize { get; set; }
        /// <summary>
        /// Max elements to dequeue in one shot from the Q by the statecache thread. Allowed values are 1-10000. Field introduced in
        /// 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "sc_dns_q_batch_dequeue_limit")]
        public int? ScDnsQBatchDequeueLimit { get; set; }
        /// <summary>
        /// Max elements in the dns queue between seagent main and the statecache thread. Allowed values are 1-10000. Field
        /// introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "sc_dns_q_max_size")]
        public int? ScDnsQMaxSize { get; set; }
        /// <summary>
        /// Max time to wait by the statecache thread before cleaning up connection to the controller shard. Allowed values are
        /// 1-1000000. Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "sc_shard_cleanup_max_time")]
        public int? ScShardCleanupMaxTime { get; set; }
        /// <summary>
        /// Max elements to dequeue in one shot from the state_ring by the statecache thread. Allowed values are 1-10000. Field
        /// introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sc_state_ring_batch_dequeue_limit")]
        public int? ScStateRingBatchDequeueLimit { get; set; }
        /// <summary>
        /// Interval for update of operational states to controller. Allowed values are 1-10000. Field introduced in 18.2.5. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "sc_states_flush_interval")]
        public int? ScStatesFlushInterval { get; set; }
        /// <summary>
        /// Interval for checking health of grpc streams to statecache_mgr. Allowed values are 1-90000. Field introduced in 18.2.5.
        /// Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "sc_stream_check_interval")]
        public int? ScStreamCheckInterval { get; set; }
        /// <summary>
        /// Max elements to dequeue in one shot from the Q by the statecache thread. Allowed values are 1-10000. Field introduced in
        /// 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sc_thread_q_batch_dequeue_limit")]
        public int? ScThreadQBatchDequeueLimit { get; set; }
        /// <summary>
        /// Max elements in the Q between seagent main and the statecache thread. Allowed values are 1-10000. Field introduced in
        /// 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "sc_thread_q_max_size")]
        public int? ScThreadQMaxSize { get; set; }
        /// <summary>
        /// Interval for grpc thread to sleep between doing work. Allowed values are 1-10000. Field introduced in 18.2.5. Unit is
        /// MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "sc_thread_sleep_interval")]
        public int? ScThreadSleepInterval { get; set; }
    }
}
