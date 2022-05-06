using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBClusterServiceRestoredEventType
    {
        /// <summary>
        /// Name of controller node.
        /// </summary>
        [JsonProperty(PropertyName = "node_name")]
        public string? NodeName { get; set; }
        /// <summary>
        /// Name of the controller service.
        /// </summary>
        [JsonProperty(PropertyName = "service_name")]
        public string? ServiceName { get; set; }
    }
}
