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
    public class NSXTALBVsSwitchoverEventDetailsType 
    {
        /// <summary>
        /// Error messages associated with this Event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// VIP IPv4 address. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// VIP IPv6 address. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip6")]
        public string? Ip6 { get; set; }
        /// <summary>
        /// Status of Event. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rpc_status")]
        public long? RpcStatus { get; set; }
        /// <summary>
        /// List of ServiceEngine assigned to this Virtual Service. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_assigned")]
        public IList<NSXTALBVipSeAssignedType> SeAssigned { get; set; }
        /// <summary>
        /// Resources requested/assigned to this Virtual Service. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_requested")]
        public NSXTALBVirtualServiceResourceType SeRequested { get; set; }
        /// <summary>
        /// Virtual Service UUID. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
