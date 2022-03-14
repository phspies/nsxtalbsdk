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
    public class NSXTALBCCScaleSetNotifDetailsType 
    {
        /// <summary>
        /// Cloud id. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Detailed reason for the scale set notification. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// Names of scale sets for which polling failed. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "scaleset_names")]
        public IList<string> ScalesetNames { get; set; }
    }
}
