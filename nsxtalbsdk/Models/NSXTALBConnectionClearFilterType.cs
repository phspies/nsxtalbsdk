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
    public class NSXTALBConnectionClearFilterType 
    {
        public NSXTALBConnectionClearFilterType()
        {
        }
        /// <summary>
        /// IP address in dotted decimal notation.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr")]
        public string? IpAddr { get; set; }
        /// <summary>
        /// Port number.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }
}
