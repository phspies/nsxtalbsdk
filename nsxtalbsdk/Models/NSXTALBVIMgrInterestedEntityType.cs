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
    public class NSXTALBVIMgrInterestedEntityType 
    {
        public NSXTALBVIMgrInterestedEntityType()
        {
        }
        /// <summary>
        /// Unique object identifier of interested.
        /// </summary>
        [JsonProperty(PropertyName = "interested_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string InterestedUuid { get; set; }
    }
}
