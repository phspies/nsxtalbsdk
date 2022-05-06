using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBObjSyncConfigType
    {
        /// <summary>
        /// SE CPU limit for InterSE Object Distribution. Allowed values are 15-80. Field introduced in 20.1.3. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "objsync_cpu_limit")]
        public int? ObjsyncCpuLimit { get; set; }
        /// <summary>
        /// Hub election interval for InterSE Object Distribution. Allowed values are 30-300. Field introduced in 20.1.3. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "objsync_hub_elect_interval")]
        public int? ObjsyncHubElectInterval { get; set; }
        /// <summary>
        /// Reconcile interval for InterSE Object Distribution. Allowed values are 1-120. Field introduced in 20.1.3. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "objsync_reconcile_interval")]
        public int? ObjsyncReconcileInterval { get; set; }
    }
}
