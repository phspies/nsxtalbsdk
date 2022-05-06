using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeBgpPeerStateChangeDetailsType
    {
        /// <summary>
        /// IP address of BGP peer. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PeerIp { get; set; }
        /// <summary>
        /// BGP peer state. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "peer_state")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PeerState { get; set; }
        /// <summary>
        /// Name of Virtual Routing Context in which BGP is configured. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_name")]
        public string? VrfName { get; set; }
    }
}
