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
    public class NSXTALBHealthMonitorFtpType 
    {
        /// <summary>
        /// Filename to download with full path. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "filename", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Filename { get; set; }
        /// <summary>
        /// FTP data transfer process mode. Enum options - FTP_PASSIVE_MODE, FTP_PORT_MODE. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mode { get; set; }
        /// <summary>
        /// SSL attributes for FTPS monitor. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}
