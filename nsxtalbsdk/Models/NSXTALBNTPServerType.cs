using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNTPServerType
    {
        /// <summary>
        /// Key number from the list of trusted keys used to authenticate this server. Allowed values are 1-65534.
        /// </summary>
        [JsonProperty(PropertyName = "key_number")]
        public int? KeyNumber { get; set; }
        /// <summary>
        /// IP Address of the NTP Server.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Server { get; set; }
    }
}
