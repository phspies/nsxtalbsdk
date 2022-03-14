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
    public class NSXTALBVinfraVcenterNetworkLimitType 
    {
        public NSXTALBVinfraVcenterNetworkLimitType()
        {
        }
        /// <summary>
        /// additional_reason of VinfraVcenterNetworkLimit.
        /// </summary>
        [JsonProperty(PropertyName = "additional_reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AdditionalReason { get; set; }
        /// <summary>
        /// Number of current.
        /// </summary>
        [JsonProperty(PropertyName = "current", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Current { get; set; }
        /// <summary>
        /// Number of limit.
        /// </summary>
        [JsonProperty(PropertyName = "limit", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Limit { get; set; }
    }
}
