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
    public class NSXTALBAdaptReplEventInfoType 
    {
        /// <summary>
        /// Object config version info. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_info")]
        public NSXTALBConfigVersionStatusType ObjInfo { get; set; }
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
    }
}
