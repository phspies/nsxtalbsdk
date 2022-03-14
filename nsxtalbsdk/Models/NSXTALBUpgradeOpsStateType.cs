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
    public class NSXTALBUpgradeOpsStateType 
    {
        /// <summary>
        /// The last time the state changed. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Descriptive reason for the state-change. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// State for keeping track of reboot status during upgrade operation. Field introduced in 20.1.2. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "rebooted")]
        public bool? Rebooted { get; set; }
        /// <summary>
        /// The upgrade operations current fsm-state. Enum options - UPGRADE_FSM_INIT, UPGRADE_FSM_STARTED, UPGRADE_FSM_WAITING,
        /// UPGRADE_FSM_IN_PROGRESS, UPGRADE_FSM_ENQUEUED, UPGRADE_FSM_ERROR, UPGRADE_FSM_SUSPENDED, UPGRADE_FSM_ENQUEUE_FAILED,
        /// UPGRADE_FSM_PAUSED, UPGRADE_FSM_COMPLETED, UPGRADE_FSM_ABORT_IN_PROGRESS, UPGRADE_FSM_ABORTED,
        /// UPGRADE_FSM_SE_UPGRADE_IN_PROGRESS, UPGRADE_FSM_CONTROLLER_COMPLETED, UPGRADE_FSM_DUMMY_3, UPGRADE_FSM_DUMMY_4,
        /// UPGRADE_FSM_DUMMY_5. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
    }
}
