using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSecMgrDataEventType
    {
        /// <summary>
        /// Type of the generated for an application. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Name of the application. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
