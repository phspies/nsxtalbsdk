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
    public class NSXTALBVipRuntimeType 
    {
        /// <summary>
        /// ev of VipRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "ev")]
        public IList<string> Ev { get; set; }
        /// <summary>
        /// Placeholder for description of property ev_status of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ev_status")]
        public NSXTALBVsEvStatusType EvStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property first_se_assigned_time of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "first_se_assigned_time")]
        public NSXTALBTimeStampType FirstSeAssignedTime { get; set; }
        /// <summary>
        /// Placeholder for description of property first_time_placement of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "first_time_placement")]
        public bool? FirstTimePlacement { get; set; }
        /// <summary>
        /// fsm_state_id of VipRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "fsm_state_id")]
        public string? FsmStateId { get; set; }
        /// <summary>
        /// fsm_state_name of VipRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "fsm_state_name")]
        public string? FsmStateName { get; set; }
        /// <summary>
        /// Placeholder for description of property last_changed_time of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Placeholder for description of property last_scale_status of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "last_scale_status")]
        public NSXTALBScaleStatusType LastScaleStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property marked_for_delete of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "marked_for_delete")]
        public bool? MarkedForDelete { get; set; }
        /// <summary>
        /// Enum options - METRICS_MGR_PORT_0, METRICS_MGR_PORT_1, METRICS_MGR_PORT_2, METRICS_MGR_PORT_3.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_mgr_port")]
        public string? MetricsMgrPort { get; set; }
        /// <summary>
        /// Placeholder for description of property migrate_in_progress of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "migrate_in_progress")]
        public bool? MigrateInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property migrate_request of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "migrate_request")]
        public NSXTALBVsMigrateParamsType MigrateRequest { get; set; }
        /// <summary>
        /// Placeholder for description of property migrate_scalein_pending of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "migrate_scalein_pending")]
        public bool? MigrateScaleinPending { get; set; }
        /// <summary>
        /// Placeholder for description of property migrate_scaleout_pending of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "migrate_scaleout_pending")]
        public bool? MigrateScaleoutPending { get; set; }
        /// <summary>
        /// Number of num_additional_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_additional_se")]
        public int? NumAdditionalSe { get; set; }
        /// <summary>
        /// Enum options - METRICS_MGR_PORT_0, METRICS_MGR_PORT_1, METRICS_MGR_PORT_2, METRICS_MGR_PORT_3.
        /// </summary>
        [JsonProperty(PropertyName = "prev_metrics_mgr_port")]
        public string? PrevMetricsMgrPort { get; set; }
        /// <summary>
        /// Number of progress_percent.
        /// </summary>
        [JsonProperty(PropertyName = "progress_percent")]
        public int? ProgressPercent { get; set; }
        /// <summary>
        /// Placeholder for description of property requested_resource of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "requested_resource")]
        public NSXTALBVirtualServiceResourceType RequestedResource { get; set; }
        /// <summary>
        /// Placeholder for description of property scale_status of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "scale_status")]
        public NSXTALBScaleStatusType ScaleStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property scalein_in_progress of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "scalein_in_progress")]
        public bool? ScaleinInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property scalein_request of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "scalein_request")]
        public NSXTALBVsScaleinParamsType ScaleinRequest { get; set; }
        /// <summary>
        /// Placeholder for description of property scaleout_in_progress of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "scaleout_in_progress")]
        public bool? ScaleoutInProgress { get; set; }
        /// <summary>
        /// Placeholder for description of property se_list of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_list")]
        public IList<NSXTALBSeListType> SeList { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "servers_configured")]
        public bool? ServersConfigured { get; set; }
        /// <summary>
        /// Placeholder for description of property supp_runtime_status of obj type VipRuntime field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "supp_runtime_status")]
        public NSXTALBOperationalStatusType SuppRuntimeStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property user_scaleout_pending of obj type VipRuntime field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "user_scaleout_pending")]
        public bool? UserScaleoutPending { get; set; }
        /// <summary>
        /// vip_id of VipRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// VIP finished resyncing with resource manager. Field introduced in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "warmstart_resync_done")]
        public bool? WarmstartResyncDone { get; set; }
        /// <summary>
        /// RPC sent to resource manager for warmstart resync. Field introduced in 18.1.4, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "warmstart_resync_sent")]
        public bool? WarmstartResyncSent { get; set; }
    }
}
