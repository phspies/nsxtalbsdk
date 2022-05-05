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
    public class NSXTALBStaticIpRangeType 
    {
        /// <summary>
        /// IP range. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrRangeType Range { get; set; }
        /// <summary>
        /// Object type (VIP only, Service Engine only, or both) which can use this IP range. Enum options - STATIC_IPS_FOR_SE,
        /// STATIC_IPS_FOR_VIP, STATIC_IPS_FOR_VIP_AND_SE. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
