using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPoolServerType
    {
        /// <summary>
        /// DNS resolvable name of the server.  May be used in place of the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// IP address of the server in the poool.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Port of the pool server listening for HTTP/HTTPS. Default value is the default port in the pool. Allowed values are
        /// 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
    }
}
