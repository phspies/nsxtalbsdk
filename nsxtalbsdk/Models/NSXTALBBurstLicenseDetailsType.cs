using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBurstLicenseDetailsType
    {
        /// <summary>
        /// Number of cores.
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public int? Cores { get; set; }
        /// <summary>
        /// end_time of BurstLicenseDetails.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// se_name of BurstLicenseDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// start_time of BurstLicenseDetails.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
    }
}
