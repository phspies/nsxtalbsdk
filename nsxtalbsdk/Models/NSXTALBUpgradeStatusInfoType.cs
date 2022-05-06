using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBUpgradeStatusInfoType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Backward compatible abort function name. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "after_reboot_rollback_fnc")]
        public string? AfterRebootRollbackFnc { get; set; }
        /// <summary>
        /// Backward compatible task dict name. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "after_reboot_task_name")]
        public string? AfterRebootTaskName { get; set; }
        /// <summary>
        /// Flag for clean installation. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "clean")]
        public bool? Clean { get; set; }
        /// <summary>
        /// Duration of Upgrade operation in seconds. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }
        /// <summary>
        /// Check if the patch rollback is possible on this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_patch_rollback")]
        public bool? EnablePatchRollback { get; set; }
        /// <summary>
        /// Check if the rollback is possible on this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rollback")]
        public bool? EnableRollback { get; set; }
        /// <summary>
        /// End time of Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// Enqueue time of Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "enqueue_time")]
        public string? EnqueueTime { get; set; }
        /// <summary>
        /// Fips mode for the entire system. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "fips_mode")]
        public bool? FipsMode { get; set; }
        /// <summary>
        /// Record of past operations on this node. Field introduced in 20.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "history")]
        public IList<NSXTALBOpsHistoryType> History { get; set; }
        /// <summary>
        /// Image path of current base image. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "image_path")]
        public string? ImagePath { get; set; }
        /// <summary>
        /// Image uuid for identifying the current base image. It is a reference to an object of type Image. Field introduced in
        /// 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "image_ref")]
        public string? ImageRef { get; set; }
        /// <summary>
        /// Name of the system such as cluster name, se group name and se name. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Type of the system such as controller_cluster, se_group or se. Enum options - NODE_CONTROLLER_CLUSTER, NODE_SE_GROUP,
        /// NODE_SE_TYPE. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "node_type")]
        public string? NodeType { get; set; }
        /// <summary>
        /// Cloud that this object belongs to. It is a reference to an object of type Cloud. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "obj_cloud_ref")]
        public string? ObjCloudRef { get; set; }
        /// <summary>
        /// Parameters associated with the Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public NSXTALBUpgradeOpsParamType Params { get; set; }
        /// <summary>
        /// Image path of current patch image. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_image_path")]
        public string? PatchImagePath { get; set; }
        /// <summary>
        /// Image uuid for identifying the current patch.Example  Base-image is 18.2.6 and a patch 6p1 is applied, then this field
        /// will indicate the 6p1 value. . It is a reference to an object of type Image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_image_ref")]
        public string? PatchImageRef { get; set; }
        /// <summary>
        /// List of patches applied to this node. Example  Base-image is 18.2.6 and a patch 6p1 is applied, then a patch 6p5
        /// applied. This field will indicate the [{'6p1', '6p1_image_uuid'}, {'6p5', '6p5_image_uuid'}] value. Field introduced in
        /// 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_list")]
        public IList<NSXTALBPatchDataType> PatchList { get; set; }
        /// <summary>
        /// Flag for patch op with reboot. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "patch_reboot")]
        public bool? PatchReboot { get; set; }
        /// <summary>
        /// Current patch version applied to this node. Example  Base-image is 18.2.6 and a patch 6p1 is applied, then this field
        /// will indicate the 6p1 value. . Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "patch_version")]
        public string? PatchVersion { get; set; }
        /// <summary>
        /// Image path of previous base image. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "prev_image_path")]
        public string? PrevImagePath { get; set; }
        /// <summary>
        /// Image path of previous patch image. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "prev_patch_image_path")]
        public string? PrevPatchImagePath { get; set; }
        /// <summary>
        /// Image uuid for identifying previous base image.Example  Base-image was 18.2.5 and an upgrade was done to 18.2.6, then
        /// this field will indicate the 18.2.5 value. . It is a reference to an object of type Image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "previous_image_ref")]
        public string? PreviousImageRef { get; set; }
        /// <summary>
        /// Image uuid for identifying previous patch.Example  Base-image was 18.2.6 with a patch 6p1. Upgrade was initiated to
        /// 18.2.8 with patch 8p1. The previous_image field will contain 18.2.6 and this field will indicate the 6p1 value. . It is
        /// a reference to an object of type Image. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "previous_patch_image_ref")]
        public string? PreviousPatchImageRef { get; set; }
        /// <summary>
        /// List of patches applied to this node on previous major version. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "previous_patch_list")]
        public IList<NSXTALBPatchDataType> PreviousPatchList { get; set; }
        /// <summary>
        /// Previous patch version applied to this node.Example  Base-image was 18.2.6 with a patch 6p1. Upgrade was initiated to
        /// 18.2.8 with patch 8p1. The previous_image field will contain 18.2.6 and this field will indicate the 6p1 value. . Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "previous_patch_version")]
        public string? PreviousPatchVersion { get; set; }
        /// <summary>
        /// Previous version prior to upgrade.Example  Base-image was 18.2.5 and an upgrade was done to 18.2.6, then this field will
        /// indicate the 18.2.5 value. . Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "previous_version")]
        public string? PreviousVersion { get; set; }
        /// <summary>
        /// Upgrade operations progress which holds value between 0-100. Allowed values are 0-100. Field introduced in 18.2.8,
        /// 20.1.1. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; set; }
        /// <summary>
        /// Image path of se patch image.(required in case of reimage and upgrade + patch). Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_patch_image_path")]
        public string? SePatchImagePath { get; set; }
        /// <summary>
        /// Image uuid for identifying the current se patch required in case of system upgrade(re-image) with se patch. . It is a
        /// reference to an object of type Image. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_patch_image_ref")]
        public string? SePatchImageRef { get; set; }
        /// <summary>
        /// ServiceEngineGroup upgrade errors. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_events")]
        public IList<NSXTALBSeUpgradeEventsType> SeUpgradeEvents { get; set; }
        /// <summary>
        /// se_patch may be different from the controller_patch. It has to be saved in the journal for subsequent consumption. The
        /// SeGroup params will be saved in the controller entry as seg_params. . Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "seg_params")]
        public NSXTALBUpgradeOpsParamType SegParams { get; set; }
        /// <summary>
        /// Detailed SeGroup status. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "seg_status")]
        public NSXTALBSeGroupStatusType SegStatus { get; set; }
        /// <summary>
        /// Start time of Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
        /// <summary>
        /// Current status of the Upgrade operation. Field introduced in 18.2.6.
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
        /// Flag is set only in the cluster if the upgrade is initiated as a system-upgrade. . Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "system")]
        public bool? System { get; set; }
        /// <summary>
        /// Completed set of tasks in the Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tasks_completed")]
        public int? TasksCompleted { get; set; }
        /// <summary>
        /// Tenant that this object belongs to. It is a reference to an object of type Tenant. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Total number of tasks in the Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "total_tasks")]
        public int? TotalTasks { get; set; }
        /// <summary>
        /// Events performed for Upgrade operation. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_events")]
        public IList<NSXTALBEventMapType> UpgradeEvents { get; set; }
        /// <summary>
        /// Upgrade operations requested. Enum options - UPGRADE, PATCH, ROLLBACK, ROLLBACKPATCH, SEGROUP_RESUME. Field introduced
        /// in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_ops")]
        public string? UpgradeOps { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID Identifier for the system such as cluster, se group and se. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Current base image applied to this node. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
