using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLicenseStatusType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Saas licensing status. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "saas_status")]
        public NSXTALBSaasLicensingStatusType SaasStatus { get; set; }
        /// <summary>
        /// Pulse license service update. Field introduced in 21.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "service_update")]
        public NSXTALBLicenseServiceUpdateType ServiceUpdate { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Uuid. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
