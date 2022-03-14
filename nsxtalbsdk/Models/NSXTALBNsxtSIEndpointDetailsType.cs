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
    public class NSXTALBNsxtSIEndpointDetailsType 
    {
        /// <summary>
        /// VirtualEndpoint Path. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string? Endpoint { get; set; }
        /// <summary>
        /// Error message. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// ServiceEngineGroup name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "segroup")]
        public string? Segroup { get; set; }
        /// <summary>
        /// Services where endpoint refers. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// Endpoint Target IPs. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "targetIps")]
        public IList<string> TargetIps { get; set; }
        /// <summary>
        /// Tier1 path. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tier1")]
        public string? Tier1 { get; set; }
    }
}
