using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBTier1LogicalRouterInfoType
    {
        /// <summary>
        /// Locale-services configuration, holds T1 edge-cluster information. When VirtualService is enabled with preserve client
        /// IP, ServiceInsertion VirtualEndpoint will be created in this locale-service. By default Avi controller picks default
        /// locale-service on T1. If more than one locale-services are present, this will be used for resolving the same. Example
        /// locale-service path - /infra/tier-1s/London_Tier1Gateway1/locale-services/London_Tier1LocalServices-1. Field introduced
        /// in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "locale_service")]
        public string? LocaleService { get; set; }
        /// <summary>
        /// Overlay segment path. Example- /infra/segments/Seg-Web-T1-01. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "segment_id")]
        public string? SegmentId { get; set; }
        /// <summary>
        /// Tier1 logical router path. Example- /infra/tier-1s/T1-01. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_lr_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Tier1LrId { get; set; }
    }
}
