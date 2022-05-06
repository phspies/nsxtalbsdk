using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRmSeBootupFailEventDetailsType
    {
        /// <summary>
        /// host_name of RmSeBootupFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// reason of RmSeBootupFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_name of RmSeBootupFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
    }
}
