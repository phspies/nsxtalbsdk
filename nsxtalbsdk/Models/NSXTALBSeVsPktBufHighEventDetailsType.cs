using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeVsPktBufHighEventDetailsType
    {
        /// <summary>
        /// Current packet buffer usage of the VS.
        /// </summary>
        [JsonProperty(PropertyName = "current_value")]
        public int? CurrentValue { get; set; }
        /// <summary>
        /// Buffer usage threshold value.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public int? Threshold { get; set; }
        /// <summary>
        /// Virtual Service name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_service")]
        public string? VirtualService { get; set; }
    }
}
