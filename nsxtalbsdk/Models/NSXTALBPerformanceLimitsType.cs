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
    public class NSXTALBPerformanceLimitsType 
    {
        /// <summary>
        /// The maximum number of concurrent client conections allowed to the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_connections")]
        public int? MaxConcurrentConnections { get; set; }
        /// <summary>
        /// The maximum throughput per second for all clients allowed through the client side of the Virtual Service per SE.
        /// </summary>
        [JsonProperty(PropertyName = "max_throughput")]
        public int? MaxThroughput { get; set; }
    }
}
