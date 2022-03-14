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
    public class NSXTALBStaticIpAllocInfoType 
    {
        /// <summary>
        /// IP address. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Object metadata. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_info")]
        public string? ObjInfo { get; set; }
        /// <summary>
        /// Object which this IP address is allocated to. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "obj_uuid")]
        public string? ObjUuid { get; set; }
    }
}
