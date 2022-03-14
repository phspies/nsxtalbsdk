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
    public class NSXTALBConnPoolPropertiesType 
    {
        /// <summary>
        /// Connection idle timeout. Allowed values are 0-86400000. Special values are 0- Infinite idle time.. Field introduced in
        /// 18.2.1. Unit is MILLISECONDS. Allowed in Basic(Allowed values- 60000) edition, Essentials(Allowed values- 60000)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_idle_tmo")]
        public int? UpstreamConnpoolConnIdleTmo { get; set; }
        /// <summary>
        /// Connection life timeout. Allowed values are 0-86400000. Special values are 0- Infinite life time.. Field introduced in
        /// 18.2.1. Unit is MILLISECONDS. Allowed in Basic(Allowed values- 600000) edition, Essentials(Allowed values- 600000)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_life_tmo")]
        public int? UpstreamConnpoolConnLifeTmo { get; set; }
        /// <summary>
        /// Maximum number of times a connection can be reused. Special values are 0- unlimited. Field introduced in 18.2.1. Allowed
        /// in Basic(Allowed values- 0) edition, Essentials(Allowed values- 0) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_conn_max_reuse")]
        public int? UpstreamConnpoolConnMaxReuse { get; set; }
        /// <summary>
        /// Maximum number of connections a server can cache. Special values are 0- unlimited. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "upstream_connpool_server_max_cache")]
        public int? UpstreamConnpoolServerMaxCache { get; set; }
    }
}
