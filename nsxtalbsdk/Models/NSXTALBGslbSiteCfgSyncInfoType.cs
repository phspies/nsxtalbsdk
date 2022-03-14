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
    public class NSXTALBGslbSiteCfgSyncInfoType 
    {
        /// <summary>
        /// Objects that could NOT be synced to the site .
        /// </summary>
        [JsonProperty(PropertyName = "errored_objects")]
        public IList<NSXTALBVersionInfoType> ErroredObjects { get; set; }
        /// <summary>
        /// Placeholder for description of property last_changed_time of obj type GslbSiteCfgSyncInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_time")]
        public NSXTALBTimeStampType LastChangedTime { get; set; }
        /// <summary>
        /// Last object having replication issue. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "last_fail_obj")]
        public NSXTALBConfigVersionStatusType LastFailObj { get; set; }
        /// <summary>
        /// Reason for the replication issues. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Recommended way to resolve replication issue. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "recommendation")]
        public string? Recommendation { get; set; }
        /// <summary>
        /// Configuration sync-state of the site . Enum options - GSLB_SITE_CFG_IN_SYNC, GSLB_SITE_CFG_OUT_OF_SYNC,
        /// GSLB_SITE_CFG_SYNC_DISABLED, GSLB_SITE_CFG_SYNC_IN_PROGRESS, GSLB_SITE_CFG_SYNC_NOT_APPLICABLE,
        /// GSLB_SITE_CFG_SYNCED_TILL_CHECKPOINT, GSLB_SITE_CFG_SYNC_SUSPENDED, GSLB_SITE_CFG_SYNC_STALLED.
        /// </summary>
        [JsonProperty(PropertyName = "sync_state")]
        public string? SyncState { get; set; }
    }
}
