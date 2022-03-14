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
    public class NSXTALBApiVersionDeprecatedType 
    {
        public NSXTALBApiVersionDeprecatedType()
        {
        }
        /// <summary>
        /// API version used. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "api_version_used")]
        public string? ApiVersionUsed { get; set; }
        /// <summary>
        /// IP address of client who sent the request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public string? ClientIp { get; set; }
        /// <summary>
        /// Minimum supported API version. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "min_supported_api_version")]
        public string? MinSupportedApiVersion { get; set; }
        /// <summary>
        /// URI of the request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// User who sent the request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
