using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBvNICNetworkType
    {
        /// <summary>
        /// Placeholder for description of property ctlr_alloc of obj type vNICNetwork field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "ctlr_alloc")]
        public bool? CtlrAlloc { get; set; }
        /// <summary>
        /// Placeholder for description of property ip of obj type vNICNetwork field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Ip { get; set; }
        /// <summary>
        /// Enum options - DHCP, STATIC, VIP, DOCKER_HOST.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mode { get; set; }
    }
}
