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
    public class NSXTALBSeGroupOptionsType 
    {
        /// <summary>
        /// The error recovery action configured for a SE Group. Enum options - ROLLBACK_UPGRADE_OPS_ON_ERROR,
        /// SUSPEND_UPGRADE_OPS_ON_ERROR, CONTINUE_UPGRADE_OPS_ON_ERROR. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "action_on_error")]
        public string? ActionOnError { get; set; }
        /// <summary>
        /// Disable non-disruptive mechanism. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "disruptive")]
        public bool? Disruptive { get; set; }
    }
}
