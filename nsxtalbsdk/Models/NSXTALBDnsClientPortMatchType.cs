using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDnsClientPortMatchType
    {
        /// <summary>
        /// Port number to match against client port number in request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_ports")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBPortMatchGenericType ClientPorts { get; set; }
    }
}
