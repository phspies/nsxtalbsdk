using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeHmEventGSDetailsType
    {
        /// <summary>
        /// GslbService name. It is a reference to an object of type GslbService.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_service")]
        public string? GslbService { get; set; }
        /// <summary>
        /// HA Compromised reason.
        /// </summary>
        [JsonProperty(PropertyName = "ha_reason")]
        public string? HaReason { get; set; }
        /// <summary>
        /// Reason Gslb Service is down.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Service Engine name.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// UUID of the event generator.
        /// </summary>
        [JsonProperty(PropertyName = "src_uuid")]
        public string? SrcUuid { get; set; }
    }
}
