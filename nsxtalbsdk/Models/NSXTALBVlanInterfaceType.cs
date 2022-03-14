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
    public class NSXTALBVlanInterfaceType 
    {
        public NSXTALBVlanInterfaceType()
        {
        }
        /// <summary>
        /// Placeholder for description of property dhcp_enabled of obj type VlanInterface field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_enabled")]
        public bool? DhcpEnabled { get; set; }
        /// <summary>
        /// Enable the interface. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// if_name of VlanInterface.
        /// </summary>
        [JsonProperty(PropertyName = "if_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string IfName { get; set; }
        /// <summary>
        /// Enable IPv6 auto configuration. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_autocfg_enabled")]
        public bool? Ip6AutocfgEnabled { get; set; }
        /// <summary>
        /// Placeholder for description of property is_mgmt of obj type VlanInterface field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "is_mgmt")]
        public bool? IsMgmt { get; set; }
        /// <summary>
        /// VLAN ID. Allowed values are 0-4096.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_id")]
        public int? VlanId { get; set; }
        /// <summary>
        /// Placeholder for description of property vnic_networks of obj type VlanInterface field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vnic_networks")]
        public IList<NSXTALBvNICNetworkType> VnicNetworks { get; set; }
        /// <summary>
        /// It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_ref")]
        public string? VrfRef { get; set; }
    }
}
