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
    public class NSXTALBVsAwaitingSeEventDetailsType 
    {
        /// <summary>
        /// Number of awaitingse_timeout.
        /// </summary>
        [JsonProperty(PropertyName = "awaitingse_timeout", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int AwaitingseTimeout { get; set; }
        /// <summary>
        /// ip of VsAwaitingSeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// Placeholder for description of property se_assigned of obj type VsAwaitingSeEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_assigned")]
        public IList<NSXTALBVipSeAssignedType> SeAssigned { get; set; }
        /// <summary>
        /// Placeholder for description of property se_requested of obj type VsAwaitingSeEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_requested")]
        public NSXTALBVirtualServiceResourceType SeRequested { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
