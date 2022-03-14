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
    public class NSXTALBRoutingServiceType 
    {
        public NSXTALBRoutingServiceType()
        {
        }
        /// <summary>
        /// Advertise reachability of backend server networks via ADC through BGP for default gateway feature. Field introduced in
        /// 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_backend_networks")]
        public bool? AdvertiseBackendNetworks { get; set; }
        /// <summary>
        /// Enable auto gateway to save and use the same L2 path to send the return traffic. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_gateway")]
        public bool? EnableAutoGateway { get; set; }
        /// <summary>
        /// Service Engine acts as Default Gateway for this service. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable_routing")]
        public bool? EnableRouting { get; set; }
        /// <summary>
        /// Enable VIP on all interfaces of this service. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vip_on_all_interfaces")]
        public bool? EnableVipOnAllInterfaces { get; set; }
        /// <summary>
        /// Use Virtual MAC address for interfaces on which floating interface IPs are placed. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enable_vmac")]
        public bool? EnableVmac { get; set; }
        /// <summary>
        /// Floating Interface IPs for the RoutingService. Field introduced in 18.2.5. Maximum of 32 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "floating_intf_ip")]
        public IList<NSXTALBIpAddrType> FloatingIntfIp { get; set; }
        /// <summary>
        /// If ServiceEngineGroup is configured for Legacy 1+1 Active Standby HA Mode, Floating IP's will be advertised only by the
        /// Active SE in the Pair. Virtual Services in this group must be disabled/enabled for any changes to the Floating IP's to
        /// take effect. Only active SE hosting VS tagged with Active Standby SE 2 Tag will advertise this floating IP when manual
        /// load distribution is enabled. Field introduced in 18.2.5. Maximum of 32 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "floating_intf_ip_se_2")]
        public IList<NSXTALBIpAddrType> FloatingIntfIpSe2 { get; set; }
        /// <summary>
        /// Routing Service related Flow profile information. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "flowtable_profile")]
        public NSXTALBFlowtableProfileType FlowtableProfile { get; set; }
        /// <summary>
        /// Enable graceful restart feature in routing service. For example, BGP. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart")]
        public bool? GracefulRestart { get; set; }
        /// <summary>
        /// NAT policy for outbound NAT functionality. This is done in post-routing. It is a reference to an object of type
        /// NatPolicy. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "nat_policy_ref")]
        public string? NatPolicyRef { get; set; }
        /// <summary>
        /// For IP Routing feature, enabling this knob will fallback to routing through Linux, by default routing is done via
        /// Service Engine data-path. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "routing_by_linux_ipstack")]
        public bool? RoutingByLinuxIpstack { get; set; }
    }
}
