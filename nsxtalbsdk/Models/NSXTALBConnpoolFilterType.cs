using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConnpoolFilterType
    {
        /// <summary>
        /// Backend or SE IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr")]
        public string? IpAddr { get; set; }
        /// <summary>
        /// Backend or SE IP address mask.
        /// </summary>
        [JsonProperty(PropertyName = "ip_mask")]
        public string? IpMask { get; set; }
        /// <summary>
        /// Backend or SE port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// cache type. Enum options - CP_ALL, CP_FREE, CP_BIND, CP_CACHED.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
