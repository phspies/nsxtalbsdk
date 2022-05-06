using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGslbDnsGsStatusType
    {
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Counter to track the number of partial updates sent.  Once it reaches the partial updates threshold, a full update is
        /// sent. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_partial_updates")]
        public int? NumPartialUpdates { get; set; }
        /// <summary>
        /// Threshold after which a full GS Status is sent. . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "partial_update_threshold")]
        public int? PartialUpdateThreshold { get; set; }
        /// <summary>
        /// State variable to trigger full or partial update. Enum options - GSLB_FULL_UPDATE_PENDING, GSLB_PARTIAL_UPDATE_PENDING.
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// Describes the type (partial/full) of the last GS status sent to Dns-VS(es). Enum options - GSLB_NO_UPDATE,
        /// GSLB_FULL_UPDATE, GSLB_PARTIAL_UPDATE. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
