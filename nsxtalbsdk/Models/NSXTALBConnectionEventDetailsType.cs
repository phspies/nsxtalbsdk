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
    public class NSXTALBConnectionEventDetailsType 
    {
        /// <summary>
        /// Destinaton host name to be connected. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Connection status information. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public string? Info { get; set; }
        /// <summary>
        /// Destinaton port to be connected. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }
}
