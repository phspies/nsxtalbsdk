using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVsMigrateEventDetailsType
    {
        /// <summary>
        /// error_message of VsMigrateEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// ip of VsMigrateEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// ip6 of VsMigrateEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// Number of rpc_status.
        /// </summary>
        [JsonProperty(PropertyName = "rpc_status")]
        public long? RpcStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property scale_status of obj type VsMigrateEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "scale_status")]
        public NSXTALBScaleStatusType ScaleStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property se_assigned of obj type VsMigrateEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_assigned")]
        public IList<NSXTALBVipSeAssignedType> SeAssigned { get; set; }
        /// <summary>
        /// Placeholder for description of property se_requested of obj type VsMigrateEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_requested")]
        public NSXTALBVirtualServiceResourceType SeRequested { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
