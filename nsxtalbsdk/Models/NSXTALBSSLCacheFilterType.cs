using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSSLCacheFilterType
    {
        /// <summary>
        /// Hexadecimal representation of the SSL session ID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_session_id")]
        public string? SslSessionId { get; set; }
    }
}
