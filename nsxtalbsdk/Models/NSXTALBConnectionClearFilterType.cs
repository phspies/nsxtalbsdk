using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConnectionClearFilterType
    {
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
