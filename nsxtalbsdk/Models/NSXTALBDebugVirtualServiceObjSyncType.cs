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
    public class NSXTALBDebugVirtualServiceObjSyncType 
    {
        /// <summary>
        /// Triggers Initial Sync on all the SEs of this VS. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "trigger_initial_sync")]
        public bool? TriggerInitialSync { get; set; }
    }
}
