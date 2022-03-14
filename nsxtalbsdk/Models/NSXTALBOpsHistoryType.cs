using nsxtalbsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOpsHistoryType 
    {
        public NSXTALBOpsHistoryType()
        {
        }
        /// <summary>
        /// Duration of Upgrade operation in seconds. Field introduced in 20.1.4. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// End time of Upgrade operation. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// Upgrade operation performed. Enum options - UPGRADE, PATCH, ROLLBACK, ROLLBACKPATCH, SEGROUP_RESUME. Field introduced in
        /// 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "ops")]
        public string? Ops { get; set; }
        /// <summary>
        /// Patch after the upgrade operation. . Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
        /// <summary>
        /// ServiceEngineGroup/SE events for upgrade operation. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_events")]
        public IList<NSXTALBSeUpgradeEventsType> SeUpgradeEvents { get; set; }
        /// <summary>
        /// SeGroup status for the upgrade operation. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "seg_status")]
        public NSXTALBSeGroupStatusType SegStatus { get; set; }
        /// <summary>
        /// Start time of Upgrade operation. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
        /// <summary>
        /// Upgrade operation status. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public NSXTALBUpgradeOpsStateType State { get; set; }
        /// <summary>
        /// Record of Pre/Post snapshot captured for current upgrade operation. It is a reference to an object of type
        /// StatediffOperation. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "statediff_ref")]
        public string? StatediffRef { get; set; }
        /// <summary>
        /// Controller events for Upgrade operation. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_events")]
        public IList<NSXTALBEventMapType> UpgradeEvents { get; set; }
        /// <summary>
        /// Image after the upgrade operation. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
