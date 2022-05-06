using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSecMgrUAEventDetailsType
    {
        /// <summary>
        /// Error descibing UA cache status in controller. Field introduced in 21.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
    }
}
