using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHealthMonitorImapType
    {
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
