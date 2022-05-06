using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBImageUploadOpsStatusType
    {
        /// <summary>
        /// The last time the state changed. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Descriptive reason for the state of the image. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Current fsm-state of image upload operation. Enum options - IMAGE_FSM_STARTED, IMAGE_FSM_IN_PROGRESS,
        /// IMAGE_FSM_COMPLETED, IMAGE_FSM_FAILED. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
    }
}
