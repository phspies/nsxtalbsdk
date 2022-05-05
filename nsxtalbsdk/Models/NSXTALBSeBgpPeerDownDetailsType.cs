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
    public class NSXTALBSeBgpPeerDownDetailsType 
    {
        /// <summary>
        /// Message specific to the down condition. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// IP address of BGP peer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PeerIp { get; set; }
        /// <summary>
        /// Name of Virtual Routing Context in which BGP is configured. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_name")]
        public string? VrfName { get; set; }
    }
}
