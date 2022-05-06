using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeIP6DadFailedEventDetailsType
    {
        /// <summary>
        /// IPv6 address.
        /// </summary>
        [JsonProperty(PropertyName = "dad_ip")]
        public NSXTALBIpAddrType DadIp { get; set; }
        /// <summary>
        /// Vnic name.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
    }
}
