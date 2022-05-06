using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBNatPolicyActionType
    {
        /// <summary>
        /// Pool of IP Addresses used for Nat. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "nat_info")]
        public IList<NSXTALBNatAddrInfoType> NatInfo { get; set; }
        /// <summary>
        /// Nat Action Type. Enum options - NAT_POLICY_ACTION_TYPE_DYNAMIC_IP_PORT. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
