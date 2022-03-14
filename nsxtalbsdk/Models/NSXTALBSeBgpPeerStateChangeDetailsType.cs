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
    public class NSXTALBSeBgpPeerStateChangeDetailsType 
    {
        public NSXTALBSeBgpPeerStateChangeDetailsType()
        {
        }
        /// <summary>
        /// IP address of BGP peer. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PeerIp { get; set; }
        /// <summary>
        /// BGP peer state. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "peer_state", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PeerState { get; set; }
        /// <summary>
        /// Name of Virtual Routing Context in which BGP is configured. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_name")]
        public string? VrfName { get; set; }
    }
}
