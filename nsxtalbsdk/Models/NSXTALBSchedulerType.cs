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
    public class NSXTALBSchedulerType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Backup Configuration to be executed by this scheduler. It is a reference to an object of type BackupConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "backup_config_ref")]
        public string? BackupConfigRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Placeholder for description of property enabled of obj type Scheduler field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Scheduler end date and time.
        /// </summary>
        [JsonProperty(PropertyName = "end_date_time")]
        public string? EndDateTime { get; set; }
        /// <summary>
        /// Frequency at which CUSTOM scheduler will run. Allowed values are 0-60.
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public int? Frequency { get; set; }
        /// <summary>
        /// Unit at which CUSTOM scheduler will run. Enum options - SCHEDULER_FREQUENCY_UNIT_MIN, SCHEDULER_FREQUENCY_UNIT_HOUR,
        /// SCHEDULER_FREQUENCY_UNIT_DAY, SCHEDULER_FREQUENCY_UNIT_WEEK, SCHEDULER_FREQUENCY_UNIT_MONTH.
        /// </summary>
        [JsonProperty(PropertyName = "frequency_unit")]
        public string? FrequencyUnit { get; set; }
        /// <summary>
        /// Name of scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Scheduler Run Mode. Enum options - RUN_MODE_PERIODIC, RUN_MODE_AT, RUN_MODE_NOW.
        /// </summary>
        [JsonProperty(PropertyName = "run_mode")]
        public string? RunMode { get; set; }
        /// <summary>
        /// Control script to be executed by this scheduler. It is a reference to an object of type AlertScriptConfig.
        /// </summary>
        [JsonProperty(PropertyName = "run_script_ref")]
        public string? RunScriptRef { get; set; }
        /// <summary>
        /// Define Scheduler Action. Enum options - SCHEDULER_ACTION_RUN_A_SCRIPT, SCHEDULER_ACTION_BACKUP.
        /// </summary>
        [JsonProperty(PropertyName = "scheduler_action")]
        public string? SchedulerAction { get; set; }
        /// <summary>
        /// Scheduler start date and time.
        /// </summary>
        [JsonProperty(PropertyName = "start_date_time")]
        public string? StartDateTime { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
