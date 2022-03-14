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
    public class NSXTALBSeGroupStatusType 
    {
        public NSXTALBSeGroupStatusType()
        {
        }
        /// <summary>
        /// Controller version. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "controller_version")]
        public string? ControllerVersion { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "disrupted_vs_ref")]
        public IList<string> DisruptedVsRef { get; set; }
        /// <summary>
        /// duration of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string? Duration { get; set; }
        /// <summary>
        /// end_time of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public string? EndTime { get; set; }
        /// <summary>
        /// enqueue_time of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "enqueue_time")]
        public string? EnqueueTime { get; set; }
        /// <summary>
        /// Enum options - HA_MODE_SHARED_PAIR, HA_MODE_SHARED, HA_MODE_LEGACY_ACTIVE_STANDBY.
        /// </summary>
        [JsonProperty(PropertyName = "ha_mode")]
        public string? HaMode { get; set; }
        /// <summary>
        /// ServiceEngineGroup upgrade in progress. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "in_progress")]
        public bool? InProgress { get; set; }
        /// <summary>
        /// notes of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public IList<string> Notes { get; set; }
        /// <summary>
        /// Number of num_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_se")]
        public int? NumSe { get; set; }
        /// <summary>
        /// Number of num_se_with_no_vs.
        /// </summary>
        [JsonProperty(PropertyName = "num_se_with_no_vs")]
        public int? NumSeWithNoVs { get; set; }
        /// <summary>
        /// Number of num_se_with_vs_not_scaledout.
        /// </summary>
        [JsonProperty(PropertyName = "num_se_with_vs_not_scaledout")]
        public int? NumSeWithVsNotScaledout { get; set; }
        /// <summary>
        /// Number of num_se_with_vs_scaledout.
        /// </summary>
        [JsonProperty(PropertyName = "num_se_with_vs_scaledout")]
        public int? NumSeWithVsScaledout { get; set; }
        /// <summary>
        /// Number of num_vs.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs")]
        public int? NumVs { get; set; }
        /// <summary>
        /// Number of num_vs_disrupted.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs_disrupted")]
        public int? NumVsDisrupted { get; set; }
        /// <summary>
        /// Number of progress.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; set; }
        /// <summary>
        /// reason of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public IList<string> Reason { get; set; }
        /// <summary>
        /// request_time of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "request_time")]
        public string? RequestTime { get; set; }
        /// <summary>
        /// ServiceEngines are already upgraded before the upgrade. It is a reference to an object of type ServiceEngine. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_already_upgraded_at_start")]
        public IList<string> SeAlreadyUpgradedAtStart { get; set; }
        /// <summary>
        /// ServiceEngines in disconnected state before starting the upgrade. It is a reference to an object of type ServiceEngine.
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_disconnected_at_start")]
        public IList<string> SeDisconnectedAtStart { get; set; }
        /// <summary>
        /// se_group_name of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_name")]
        public string? SeGroupName { get; set; }
        /// <summary>
        /// Unique object identifier of se_group.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_uuid")]
        public string? SeGroupUuid { get; set; }
        /// <summary>
        /// ServiceEngines local ip not present before the upgrade. It is a reference to an object of type ServiceEngine. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_ip_missing_at_start")]
        public IList<string> SeIpMissingAtStart { get; set; }
        /// <summary>
        /// ServiceEngines in poweredoff state before the upgrade. It is a reference to an object of type ServiceEngine. Field
        /// introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_poweredoff_at_start")]
        public IList<string> SePoweredoffAtStart { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_reboot_in_progress_ref")]
        public string? SeRebootInProgressRef { get; set; }
        /// <summary>
        /// ServiceEngines upgrade completed. It is a reference to an object of type ServiceEngine. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_completed")]
        public IList<string> SeUpgradeCompleted { get; set; }
        /// <summary>
        /// ServiceEngineGroup upgrade errors. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_errors")]
        public IList<NSXTALBSeUpgradeEventsType> SeUpgradeErrors { get; set; }
        /// <summary>
        /// ServiceEngines upgrade failed. It is a reference to an object of type ServiceEngine. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_failed")]
        public IList<string> SeUpgradeFailed { get; set; }
        /// <summary>
        /// ServiceEngines upgrade in progress. It is a reference to an object of type ServiceEngine. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_in_progress")]
        public IList<string> SeUpgradeInProgress { get; set; }
        /// <summary>
        /// ServiceEngines upgrade not started. It is a reference to an object of type ServiceEngine. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_not_started")]
        public IList<string> SeUpgradeNotStarted { get; set; }
        /// <summary>
        /// Service Engines that were in suspended state and were skipped upon Service Engine Group ugprade resumption. It is a
        /// reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_skip_suspended")]
        public IList<string> SeUpgradeSkipSuspended { get; set; }
        /// <summary>
        /// Service Engines which triggered Service Engine Group to be in suspended state. It is a reference to an object of type
        /// ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_upgrade_suspended")]
        public IList<string> SeUpgradeSuspended { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_with_no_vs")]
        public IList<string> SeWithNoVs { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_with_vs_not_scaledout")]
        public IList<string> SeWithVsNotScaledout { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_with_vs_scaledout")]
        public IList<string> SeWithVsScaledout { get; set; }
        /// <summary>
        /// start_time of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public string? StartTime { get; set; }
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
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// thread of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "thread")]
        public string? Thread { get; set; }
        /// <summary>
        /// Enum options - TRAFFIC_DISRUPTED, TRAFFIC_NOT_DISRUPTED.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_status")]
        public string? TrafficStatus { get; set; }
        /// <summary>
        /// VirtualService errors during the SeGroup upgrade. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "vs_errors")]
        public IList<NSXTALBVsErrorType> VsErrors { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_migrate_in_progress_ref")]
        public IList<string> VsMigrateInProgressRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_scalein_in_progress_ref")]
        public IList<string> VsScaleinInProgressRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_scaleout_in_progress_ref")]
        public IList<string> VsScaleoutInProgressRef { get; set; }
        /// <summary>
        /// worker of SeGroupStatus.
        /// </summary>
        [JsonProperty(PropertyName = "worker")]
        public string? Worker { get; set; }
    }
}
