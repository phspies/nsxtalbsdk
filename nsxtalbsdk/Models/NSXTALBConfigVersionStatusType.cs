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
    public class NSXTALBConfigVersionStatusType 
    {
        /// <summary>
        /// Type of replication event. Enum options - DNSVS, OBJECT_CONFIG_VERSION. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "event_type")]
        public string? EventType { get; set; }
        /// <summary>
        /// Name of config object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_name")]
        public string? ObjName { get; set; }
        /// <summary>
        /// UUID of config object. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_uuid")]
        public string? ObjUuid { get; set; }
    }
}
