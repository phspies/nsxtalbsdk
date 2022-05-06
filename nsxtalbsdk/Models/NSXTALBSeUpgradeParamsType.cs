using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeUpgradeParamsType
    {
        /// <summary>
        /// This field is used to disable scale-in/scale out operations during upgrade operations. .
        /// </summary>
        [JsonProperty(PropertyName = "disruptive")]
        public bool? Disruptive { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
        /// <summary>
        /// Upgrade System with patch upgrade. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "patch")]
        public bool? Patch { get; set; }
        /// <summary>
        /// Rollback System with patch upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "patch_rollback")]
        public bool? PatchRollback { get; set; }
        /// <summary>
        /// Resume from suspended state.
        /// </summary>
        [JsonProperty(PropertyName = "resume_from_suspend")]
        public bool? ResumeFromSuspend { get; set; }
        /// <summary>
        /// It is used in rollback operations. .
        /// </summary>
        [JsonProperty(PropertyName = "rollback")]
        public bool? Rollback { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngineGroup. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_refs")]
        public IList<string> SeGroupRefs { get; set; }
        /// <summary>
        /// When set, this will skip upgrade on the Service Engine which is upgrade suspended state.
        /// </summary>
        [JsonProperty(PropertyName = "skip_suspended")]
        public bool? SkipSuspended { get; set; }
        /// <summary>
        /// When set to true, if there is any failure during the SE upgrade, upgrade will be suspended for this SE group and manual
        /// intervention would be needed to resume the upgrade. Field introduced in 17.1.4.
        /// </summary>
        [JsonProperty(PropertyName = "suspend_on_failure")]
        public bool? SuspendOnFailure { get; set; }
        /// <summary>
        /// Field deprecated in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "test")]
        public bool? Test { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
