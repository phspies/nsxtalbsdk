using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBCloudAutoscalingConfigFailureDetailsType
    {
        /// <summary>
        /// Cloud UUID. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Failure reason if Autoscaling configuration fails. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
    }
}
