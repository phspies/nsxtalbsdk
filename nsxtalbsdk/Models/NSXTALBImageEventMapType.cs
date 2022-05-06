using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBImageEventMapType
    {
        /// <summary>
        /// List of all events node wise. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "nodes_events")]
        public IList<NSXTALBImageEventType> NodesEvents { get; set; }
        /// <summary>
        /// List of all events node wise. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "sub_events")]
        public IList<NSXTALBImageEventType> SubEvents { get; set; }
        /// <summary>
        /// Name representing the task. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "task_name")]
        public string? TaskName { get; set; }
    }
}
