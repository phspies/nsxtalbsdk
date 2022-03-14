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
    public class NSXTALBLogAgentTCPClientEventDetailType 
    {
        public NSXTALBLogAgentTCPClientEventDetailType()
        {
        }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public string? ErrorCode { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_reason")]
        public string? ErrorReason { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
    }
}
