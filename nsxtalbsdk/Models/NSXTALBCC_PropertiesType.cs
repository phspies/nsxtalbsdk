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
    public class NSXTALBCC_PropertiesType 
    {
        /// <summary>
        /// Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "rpc_poll_interval")]
        public int? RpcPollInterval { get; set; }
        /// <summary>
        /// Number of rpc_queue_size.
        /// </summary>
        [JsonProperty(PropertyName = "rpc_queue_size")]
        public int? RpcQueueSize { get; set; }
    }
}
