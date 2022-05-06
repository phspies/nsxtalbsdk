using Newtonsoft.Json;
using System.Linq;
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
        [JsonProperty(PropertyName = "filename")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Filename { get; set; }
        /// <summary>
        /// FTP data transfer process mode. Enum options - FTP_PASSIVE_MODE, FTP_PORT_MODE. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mode { get; set; }
        /// <summary>
        /// SSL attributes for FTPS monitor. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_attributes")]
        public NSXTALBHealthMonitorSSLAttributesType SslAttributes { get; set; }
    }
}
