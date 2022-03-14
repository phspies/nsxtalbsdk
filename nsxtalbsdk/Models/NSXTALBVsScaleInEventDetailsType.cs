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
    public class NSXTALBVsScaleInEventDetailsType 
    {
        public NSXTALBVsScaleInEventDetailsType()
        {
        }
        /// <summary>
        /// error_message of VsScaleInEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// ip of VsScaleInEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// ip6 of VsScaleInEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// Number of rpc_status.
        /// </summary>
        [JsonProperty(PropertyName = "rpc_status")]
        public long? RpcStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property scale_status of obj type VsScaleInEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "scale_status")]
        public NSXTALBScaleStatusType ScaleStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property se_assigned of obj type VsScaleInEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_assigned")]
        public IList<NSXTALBVipSeAssignedType> SeAssigned { get; set; }
        /// <summary>
        /// Placeholder for description of property se_requested of obj type VsScaleInEventDetails field type str  type object
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
