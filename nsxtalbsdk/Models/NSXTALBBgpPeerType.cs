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
    public class NSXTALBBgpPeerType 
    {
        public NSXTALBBgpPeerType()
        {
        }
        /// <summary>
        /// Advertise SNAT IP to this Peer.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_snat_ip")]
        public bool? AdvertiseSnatIp { get; set; }
        /// <summary>
        /// Advertise VIP to this Peer.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_vip")]
        public bool? AdvertiseVip { get; set; }
        /// <summary>
        /// Advertisement interval for this Peer. Allowed values are 1-60.
        /// </summary>
        [JsonProperty(PropertyName = "advertisement_interval")]
        public int? AdvertisementInterval { get; set; }
        /// <summary>
        /// Enable Bi-Directional Forward Detection. Only async mode supported.
        /// </summary>
        [JsonProperty(PropertyName = "bfd")]
        public bool? Bfd { get; set; }
        /// <summary>
        /// Connect timer for this Peer. Allowed values are 1-120.
        /// </summary>
        [JsonProperty(PropertyName = "connect_timer")]
        public int? ConnectTimer { get; set; }
        /// <summary>
        /// TTL for multihop ebgp Peer. Allowed values are 0-255. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ebgp_multihop")]
        public int? EbgpMultihop { get; set; }
        /// <summary>
        /// Hold time for this Peer. Allowed values are 3-7200.
        /// </summary>
        [JsonProperty(PropertyName = "hold_time")]
        public int? HoldTime { get; set; }
        /// <summary>
        /// Override the profile level local_as with the peer level remote_as. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ibgp_local_as_override")]
        public bool? IbgpLocalAsOverride { get; set; }
        /// <summary>
        /// Keepalive interval for this Peer. Allowed values are 0-3600.
        /// </summary>
        [JsonProperty(PropertyName = "keepalive_interval")]
        public int? KeepaliveInterval { get; set; }
        /// <summary>
        /// Label used to enable learning and/or advertisement of routes to this peer. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string? Label { get; set; }
        /// <summary>
        /// Local AS to use for this ebgp peer. If specified, this will override the local AS configured at the VRF level. Allowed
        /// values are 1-4294967295. Field introduced in 17.1.6,17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "local_as")]
        public int? LocalAs { get; set; }
        /// <summary>
        /// Peer Autonomous System Md5 Digest Secret Key.
        /// </summary>
        [JsonProperty(PropertyName = "md5_secret")]
        public string? Md5Secret { get; set; }
        /// <summary>
        /// Network providing reachability for Peer. It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// IP Address of the BGP Peer.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip")]
        public NSXTALBIpAddrType PeerIp { get; set; }
        /// <summary>
        /// IPv6 Address of the BGP Peer. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "peer_ip6")]
        public NSXTALBIpAddrType PeerIp6 { get; set; }
        /// <summary>
        /// Peer Autonomous System ID. Allowed values are 1-4294967295.
        /// </summary>
        [JsonProperty(PropertyName = "remote_as")]
        public int? RemoteAs { get; set; }
        /// <summary>
        /// Shutdown the BGP peer. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "shutdown")]
        public bool? Shutdown { get; set; }
        /// <summary>
        /// Subnet providing reachability for Peer.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// IPv6 subnet providing reachability for Peer. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
    }
}
