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
    public class NSXTALBRetryPlacementParamsType 
    {
        public NSXTALBRetryPlacementParamsType()
        {
        }
        /// <summary>
        /// Retry placement operations for all East-West services. Field introduced in 17.1.6,17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "all_east_west")]
        public bool? AllEastWest { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Indicates the vip_id that needs placement retrial. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VipId { get; set; }
    }
}
