using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBvNICType
    {
        /// <summary>
        /// adapter of vNIC.
        /// </summary>
        [JsonProperty(PropertyName = "adapter")]
        public string? Adapter { get; set; }
        /// <summary>
        /// Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "aggregator_chgd")]
        public bool? AggregatorChgd { get; set; }
        /// <summary>
        /// Placeholder for description of property can_se_dp_takeover of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "can_se_dp_takeover")]
        public bool? CanSeDpTakeover { get; set; }
        /// <summary>
        /// Placeholder for description of property connected of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }
        /// <summary>
        /// Placeholder for description of property del_pending of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "del_pending")]
        public bool? DelPending { get; set; }
        /// <summary>
        /// Delete this VNIC. Please confirm dp_deletion_done before removing the VNIC from the cloud. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "delete_vnic")]
        public bool? DeleteVnic { get; set; }
        /// <summary>
        /// Placeholder for description of property dhcp_enabled of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_enabled")]
        public bool? DhcpEnabled { get; set; }
        /// <summary>
        /// The VNIC has been cleaned up in the datapath. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "dp_deletion_done")]
        public bool? DpDeletionDone { get; set; }
        /// <summary>
        /// Placeholder for description of property enabled of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// if_name of vNIC.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// Enable IPv6 auto configuration. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_autocfg_enabled")]
        public bool? Ip6AutocfgEnabled { get; set; }
        /// <summary>
        /// Placeholder for description of property is_asm of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_asm")]
        public bool? IsAsm { get; set; }
        /// <summary>
        /// Placeholder for description of property is_avi_internal_network of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_avi_internal_network")]
        public bool? IsAviInternalNetwork { get; set; }
        /// <summary>
        /// Placeholder for description of property is_hsm of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_hsm")]
        public bool? IsHsm { get; set; }
        /// <summary>
        /// Placeholder for description of property is_mgmt of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_mgmt")]
        public bool? IsMgmt { get; set; }
        /// <summary>
        /// Placeholder for description of property is_portchannel of obj type vNIC field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_portchannel")]
        public bool? IsPortchannel { get; set; }
        /// <summary>
        /// The link is operationally up. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "link_up")]
        public bool? LinkUp { get; set; }
        /// <summary>
        /// linux_name of vNIC.
        /// </summary>
        [JsonProperty(PropertyName = "linux_name")]
        public string? LinuxName { get; set; }
        /// <summary>
        /// mac_address of vNIC.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddress { get; set; }
        /// <summary>
        /// Placeholder for description of property members of obj type vNIC field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTALBMemberInterfaceType> Members { get; set; }
        /// <summary>
        /// Number of mtu.
        /// </summary>
        [JsonProperty(PropertyName = "mtu")]
        public int? Mtu { get; set; }
        /// <summary>
        /// network_name of vNIC.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// pci_id of vNIC.
        /// </summary>
        [JsonProperty(PropertyName = "pci_id")]
        public string? PciId { get; set; }
        /// <summary>
        /// Unique object identifier of port.
        /// </summary>
        [JsonProperty(PropertyName = "port_uuid")]
        public string? PortUuid { get; set; }
        /// <summary>
        /// Number of vlan_id.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_id")]
        public int? VlanId { get; set; }
        /// <summary>
        /// Placeholder for description of property vlan_interfaces of obj type vNIC field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vlan_interfaces")]
        public IList<NSXTALBVlanInterfaceType> VlanInterfaces { get; set; }
        /// <summary>
        /// Placeholder for description of property vnic_networks of obj type vNIC field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vnic_networks")]
        public IList<NSXTALBvNICNetworkType> VnicNetworks { get; set; }
        /// <summary>
        /// Number of vrf_id.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_id")]
        public int? VrfId { get; set; }
        /// <summary>
        /// It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_ref")]
        public string? VrfRef { get; set; }
    }
}
