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
    public class NSXTALBHealthMonitorImapType 
    {
        public NSXTALBHealthMonitorImapType()
        {
        }
        /// <summary>
        /// Folder to access. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// SSL attributes for IMAPS monitor. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}
