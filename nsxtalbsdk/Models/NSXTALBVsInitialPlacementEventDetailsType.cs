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
    public class NSXTALBVsInitialPlacementEventDetailsType 
    {
        public NSXTALBVsInitialPlacementEventDetailsType()
        {
        }
        /// <summary>
        /// error_message of VsInitialPlacementEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// ip of VsInitialPlacementEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// VIP IPv6 address. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// Number of rpc_status.
        /// </summary>
        [JsonProperty(PropertyName = "rpc_status")]
        public long? RpcStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property se_assigned of obj type VsInitialPlacementEventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "se_assigned")]
        public IList<NSXTALBVipSeAssignedType> SeAssigned { get; set; }
        /// <summary>
        /// Placeholder for description of property se_requested of obj type VsInitialPlacementEventDetails field type str  type
        /// object
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
