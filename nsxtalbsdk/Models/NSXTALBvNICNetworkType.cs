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
    public class NSXTALBvNICNetworkType 
    {
        public NSXTALBvNICNetworkType()
        {
        }
        /// <summary>
        /// Placeholder for description of property ctlr_alloc of obj type vNICNetwork field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "ctlr_alloc")]
        public bool? CtlrAlloc { get; set; }
        /// <summary>
        /// Placeholder for description of property ip of obj type vNICNetwork field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Ip { get; set; }
        /// <summary>
        /// Enum options - DHCP, STATIC, VIP, DOCKER_HOST.
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mode { get; set; }
    }
}
