using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNsxtImageDetailsType
    {
        /// <summary>
        /// Cloud Id. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Error message. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Image version. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "image_version")]
        public string? ImageVersion { get; set; }
        /// <summary>
        /// VC url. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vc_url")]
        public string? VcUrl { get; set; }
    }
}
