using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBIpAddrPortType
    {
        /// <summary>
        /// Hostname of server. One of IP address or hostname should be set.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// IP Address of host. One of IP address or hostname should be set.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Port number of server. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
    }
}
