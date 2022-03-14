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
    public class NSXTALBGslbServiceSitePersistencePoolType 
    {
        /// <summary>
        /// Site persistence pool's http2 state. . Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        public bool? EnableHttp2 { get; set; }
        /// <summary>
        /// Site persistence pool's name. . Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Number of servers configured in the pool. . Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "num_servers")]
        public long? NumServers { get; set; }
        /// <summary>
        /// Number of servers operationally up in the pool. . Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "num_servers_up")]
        public long? NumServersUp { get; set; }
        /// <summary>
        /// Detailed information of the servers in the pool. . Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public IList<NSXTALBServerConfigType> Servers { get; set; }
        /// <summary>
        /// Site persistence pool's uuid. . Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
