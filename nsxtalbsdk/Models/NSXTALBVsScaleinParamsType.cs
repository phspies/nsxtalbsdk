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
    public class NSXTALBVsScaleinParamsType 
    {
        public NSXTALBVsScaleinParamsType()
        {
        }
        /// <summary>
        /// Placeholder for description of property admin_down of obj type VsScaleinParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "admin_down")]
        public bool? AdminDown { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "from_se_ref")]
        public string? FromSeRef { get; set; }
        /// <summary>
        /// Placeholder for description of property scalein_primary of obj type VsScaleinParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "scalein_primary")]
        public bool? ScaleinPrimary { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VipId { get; set; }
    }
}
