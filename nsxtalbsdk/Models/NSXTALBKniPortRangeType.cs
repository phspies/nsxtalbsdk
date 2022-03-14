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
    public class NSXTALBKniPortRangeType 
    {
        public NSXTALBKniPortRangeType()
        {
        }
        /// <summary>
        /// Protocol associated with port range. Enum options - KNI_PROTO_TCP, KNI_PROTO_UDP. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
        /// <summary>
        /// Port range to be allowed to KNI. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "range", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBPortRangeType Range { get; set; }
    }
}
