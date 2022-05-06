using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeVipInterfaceListType
    {
        /// <summary>
        /// Placeholder for description of property is_portchannel of obj type SeVipInterfaceList field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_portchannel")]
        public bool? IsPortchannel { get; set; }
        /// <summary>
        /// List of placement_networks reachable from this interface. Field introduced in 20.1.5.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<NSXTALBDiscoveredNetworkType> Networks { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_intf_ip of obj type SeVipInterfaceList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_intf_ip")]
        public NSXTALBIpAddrType VipIntfIp { get; set; }
        /// <summary>
        /// Placeholder for description of property vip_intf_ip6 of obj type SeVipInterfaceList field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vip_intf_ip6")]
        public NSXTALBIpAddrType VipIntfIp6 { get; set; }
        /// <summary>
        /// vip_intf_mac of SeVipInterfaceList.
        /// </summary>
        [JsonProperty(PropertyName = "vip_intf_mac")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VipIntfMac { get; set; }
        /// <summary>
        /// Number of vlan_id.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_id")]
        public int? VlanId { get; set; }
    }
}
