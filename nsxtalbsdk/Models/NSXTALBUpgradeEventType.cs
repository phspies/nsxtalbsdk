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
    public class NSXTALBUpgradeEventType 
    {
        /// <summary>
        /// Time taken to complete upgrade event in seconds. Field introduced in 18.2.6. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Task end time. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// Ip of the node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Upgrade event message if any. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Task start time. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
        /// <summary>
        /// Upgrade event status. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public bool? Status { get; set; }
        /// <summary>
        /// Sub tasks executed on each node. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sub_tasks")]
        public IList<string> SubTasks { get; set; }
    }
}
