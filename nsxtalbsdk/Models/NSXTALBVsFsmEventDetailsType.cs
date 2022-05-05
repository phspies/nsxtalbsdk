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
    public class NSXTALBVsFsmEventDetailsType 
    {
        /// <summary>
        /// vip_id of VsFsmEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id")]
        public string? VipId { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_rt of obj type VsFsmEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_rt")]
        public NSXTALBVirtualServiceRuntimeType VsRt { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
