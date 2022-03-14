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
    public class NSXTALBBgpProfileType 
    {
        public NSXTALBBgpProfileType()
        {
        }
        /// <summary>
        /// Community string either in aa nn format where aa, nn is within [1,65535] or local-AS|no-advertise|no-export|internet.
        /// Field introduced in 17.1.2. Maximum of 16 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "community")]
        public IList<string> Community { get; set; }
        /// <summary>
        /// Hold time for Peers. Allowed values are 3-7200.
        /// </summary>
        [JsonProperty(PropertyName = "hold_time")]
        public int? HoldTime { get; set; }
        /// <summary>
        /// BGP peer type.
        /// </summary>
        [JsonProperty(PropertyName = "ibgp", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Ibgp { get; set; }
        /// <summary>
        /// Communities per IP address range. Field introduced in 17.1.3. Maximum of 1024 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "ip_communities")]
        public IList<NSXTALBIpCommunityType> IpCommunities { get; set; }
        /// <summary>
        /// Keepalive interval for Peers. Allowed values are 0-3600.
        /// </summary>
        [JsonProperty(PropertyName = "keepalive_interval")]
        public int? KeepaliveInterval { get; set; }
        /// <summary>
        /// Local Autonomous System ID. Allowed values are 1-4294967295.
        /// </summary>
        [JsonProperty(PropertyName = "local_as", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int LocalAs { get; set; }
        /// <summary>
        /// LOCAL_PREF to be used for routes advertised. Applicable only over iBGP. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "local_preference")]
        public int? LocalPreference { get; set; }
        /// <summary>
        /// Number of times the local AS should be prepended additionally. Allowed values are 1-10. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_as_path_prepend")]
        public int? NumAsPathPrepend { get; set; }
        /// <summary>
        /// BGP Peers. Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "peers")]
        public IList<NSXTALBBgpPeerType> Peers { get; set; }
        /// <summary>
        /// Learning and advertising options for BGP peers. Field introduced in 20.1.1. Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "routing_options")]
        public IList<NSXTALBBgpRoutingOptionsType> RoutingOptions { get; set; }
        /// <summary>
        /// Send community attribute to all peers. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "send_community")]
        public bool? SendCommunity { get; set; }
        /// <summary>
        /// Shutdown the bgp. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "shutdown")]
        public bool? Shutdown { get; set; }
    }
}
