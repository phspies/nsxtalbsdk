using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBContainerCloudServiceType
    {
        /// <summary>
        /// cc_id of ContainerCloudService.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// object of ContainerCloudService.
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public string? ObjectProperty { get; set; }
        /// <summary>
        /// reason of ContainerCloudService.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// service of ContainerCloudService.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string? Service { get; set; }
        /// <summary>
        /// status of ContainerCloudService.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
    }
}
