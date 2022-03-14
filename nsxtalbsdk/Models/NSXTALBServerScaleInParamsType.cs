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
    public class NSXTALBServerScaleInParamsType 
    {
        public NSXTALBServerScaleInParamsType()
        {
        }
        /// <summary>
        /// Reason for the manual scale-in.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// List of server IDs that should be scaled in.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public IList<NSXTALBServerIdType> Servers { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
