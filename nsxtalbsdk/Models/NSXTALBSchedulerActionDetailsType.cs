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
    public class NSXTALBSchedulerActionDetailsType 
    {
        /// <summary>
        /// backup_uri of SchedulerActionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "backup_uri")]
        public IList<string> BackupUri { get; set; }
        /// <summary>
        /// control_script_output of SchedulerActionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "control_script_output")]
        public string? ControlScriptOutput { get; set; }
        /// <summary>
        /// execution_datestamp of SchedulerActionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "execution_datestamp")]
        public string? ExecutionDatestamp { get; set; }
        /// <summary>
        /// Unique object identifier of scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "scheduler_uuid")]
        public string? SchedulerUuid { get; set; }
        /// <summary>
        /// status of SchedulerActionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
    }
}
