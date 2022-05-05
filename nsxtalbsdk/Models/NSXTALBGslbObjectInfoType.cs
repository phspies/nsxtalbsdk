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
    public class NSXTALBGslbObjectInfoType 
    {
        /// <summary>
        /// Indicates the object uuid. Field introduced in 18.1.5, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "obj")]
        public NSXTALBGslbObjType Obj { get; set; }
        /// <summary>
        /// Indicates the object uuid. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "object_uuid")]
        public string? ObjectUuid { get; set; }
        /// <summary>
        /// Indicates the object type Gslb, GslbService or GslbGeoDbProfile. . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pb_name")]
        public string? PbName { get; set; }
        /// <summary>
        /// Indicates the state of the object unchanged or changed. This is used in vs-mgr to push just the uuid or uuid + protobuf
        /// to the SE-Agent. Enum options - GSLB_OBJECT_CHANGED, GSLB_OBJECT_UNCHANGED, GSLB_OBJECT_DELETE. Field introduced in
        /// 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
    }
}
