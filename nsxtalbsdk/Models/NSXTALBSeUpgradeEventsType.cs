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
    public class NSXTALBSeUpgradeEventsType 
    {
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "from_se_ref")]
        public string? FromSeRef { get; set; }
        /// <summary>
        /// Number of num_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_se")]
        public int? NumSe { get; set; }
        /// <summary>
        /// Number of num_se_group.
        /// </summary>
        [JsonProperty(PropertyName = "num_se_group")]
        public int? NumSeGroup { get; set; }
        /// <summary>
        /// Number of num_vs.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs")]
        public int? NumVs { get; set; }
        /// <summary>
        /// reason of SeUpgradeEvents.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public IList<string> Reason { get; set; }
        /// <summary>
        /// Enum options - HA_MODE_SHARED_PAIR, HA_MODE_SHARED, HA_MODE_LEGACY_ACTIVE_STANDBY.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ha_mode")]
        public string? SeGroupHaMode { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngineGroup.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        public string? SeGroupRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// List of sub_tasks executed. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "sub_tasks")]
        public IList<string> SubTasks { get; set; }
        /// <summary>
        /// Enum options - SE_UPGRADE_PREVIEW, SE_UPGRADE_IN_PROGRESS, SE_UPGRADE_COMPLETE, SE_UPGRADE_ERROR, SE_UPGRADE_PRE_CHECKS,
        /// SE_IMAGE_INSTALL, SE_UPGRADE_IMAGE_NOT_FOUND, SE_ALREADY_UPGRADED, SE_REBOOT, SE_CONNECT_AFTER_REBOOT,
        /// SE_PRE_UPGRADE_TASKS, SE_POST_UPGRADE_TASKS, SE_WAIT_FOR_SWITCHOVER, SE_CHECK_SCALEDOUT_VS_EXISTS,
        /// SE_UPGRADE_SEMGR_REQUEST, SE_UPGRADE_SEMGR_SE_UNREACHABLE, SE_PRE_UPGRADE_SCALE_IN_OPS, SE_POST_UPGRADE_SCALE_OUT_OPS,
        /// SE_UPGRADE_SUSPENDED, SE_UPGRADE_START, SE_UPGRADE_PAUSED, SE_UPGRADE_FAILED, SE_UPGRADE_VERSION_CHECKS,
        /// SE_UPGRADE_CONNECTIVITY_CHECKS, SE_UPGRADE_VERIFY_VERSION, SE_UPGRADE_SKIP_RESUME_OPS, SE_UPGRADE_SEMGR_DONE,
        /// SEGROUP_UPGRADE_NOT_STARTED, SEGROUP_UPGRADE_ENQUEUED, SEGROUP_UPGRADE_ENQUEUE_FAILED, SEGROUP_UPGRADE_IN_PROGRESS,
        /// SEGROUP_UPGRADE_COMPLETE, SEGROUP_UPGRADE_ERROR, SEGROUP_UPGRADE_SUSPENDED, VS_DISRUPTED, VS_SCALEIN, VS_SCALEIN_ERROR,
        /// VS_SCALEIN_ERROR_RPC_FAILED, VS_SCALEOUT, VS_SCALEOUT_ERROR, VS_SCALEOUT_ERROR_RPC_FAILED,
        /// VS_SCALEOUT_ERROR_SE_NOT_READY, VS_MIGRATE, VS_MIGRATE_ERROR, VS_MIGRATE_BACK, VS_MIGRATE_BACK_ERROR,
        /// VS_MIGRATE_BACK_NOT_NEEDED, VS_MIGRATE_ERROR_NO_CANDIDATE_SE, VS_MIGRATE_ERROR_RPC_FAILED,
        /// VS_MIGRATE_BACK_ERROR_SE_NOT_READY, VS_MIGRATE_BACK_ERROR_RPC_FAILED, SEGROUP_PAUSE_PLACEMENT, SEGROUP_RESUME_PLACEMENT,
        /// SEGROUP_CLOUD_DISCOVERY, SEGROUP_IMAGE_GENERATION, SEGROUP_IMAGE_COPY_INSTALL_TO_SES, SEGROUP_SERIAL_SE_UPGRADE,
        /// SEGROUP_PARALLEL_SE_UPGRADE, SEGROUP_V2_TO_V1_ROLLBACK, SEGROUP_FAILED_SE_ERROR_RECOVERY,
        /// SEGROUP_SE_CONNECTIVITY_CHECKS, SEGROUP_UPGRADE_START, SEGROUP_WAIT_FOR_WARM_START_DONE, SEGROUP_PRE_SNAPSHOT,
        /// SEGROUP_POST_SNAPSHOT, SEGROUP_WAIT_FOR_SNAPSHOT_COLLECTION.
        /// </summary>
        [JsonProperty(PropertyName = "task")]
        public string? Task { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "to_se_ref")]
        public string? ToSeRef { get; set; }
        /// <summary>
        /// Enum options - TRAFFIC_DISRUPTED, TRAFFIC_NOT_DISRUPTED.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_status")]
        public string? TrafficStatus { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_ref")]
        public string? VsRef { get; set; }
    }
}
