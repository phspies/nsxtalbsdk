using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBurstResourceType
    {
        /// <summary>
        /// License ID against which this burst has been accounted. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "accounted_license_id")]
        public string? AccountedLicenseId { get; set; }
        /// <summary>
        /// Time UTC of the last alert created for this burst resource. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "last_alert_time")]
        public string? LastAlertTime { get; set; }
        /// <summary>
        /// Enum options - ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "license_tier")]
        public string? LicenseTier { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_cookie")]
        public string? SeCookie { get; set; }
        /// <summary>
        /// Service Engine which triggered the burst license usage. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// Time UTC when the burst license was put in use. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
    }
}
