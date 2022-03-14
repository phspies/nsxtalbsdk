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
    public class NSXTALBpresnapshotType 
    {
        public NSXTALBpresnapshotType()
        {
        }
        /// <summary>
        /// FB Gs snapshot data. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gssnapshot")]
        public NSXTALBFbGsInfoType Gssnapshot { get; set; }
        /// <summary>
        /// FB Pool snapshot data. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "poolsnapshot")]
        public NSXTALBFbPoolInfoType Poolsnapshot { get; set; }
        /// <summary>
        /// FB SE snapshot data. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "sesnapshot")]
        public NSXTALBFbSeInfoType Sesnapshot { get; set; }
        /// <summary>
        /// FB VS snapshot data. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vssnapshot")]
        public NSXTALBFbVsInfoType Vssnapshot { get; set; }
    }
}
