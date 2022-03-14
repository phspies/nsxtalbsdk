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
    public class NSXTALBVipType 
    {
        public NSXTALBVipType()
        {
        }
        /// <summary>
        /// Auto-allocate floating/elastic IP from the Cloud infrastructure. Field introduced in 17.1.1. Allowed in Basic(Allowed
        /// values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_floating_ip")]
        public bool? AutoAllocateFloatingIp { get; set; }
        /// <summary>
        /// Auto-allocate VIP from the provided subnet. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_ip")]
        public bool? AutoAllocateIp { get; set; }
        /// <summary>
        /// Specifies whether to auto-allocate only a V4 address, only a V6 address, or one of each type. Enum options - V4_ONLY,
        /// V6_ONLY, V4_V6. Field introduced in 18.1.1. Allowed in Basic(Allowed values- V4_ONLY) edition, Essentials(Allowed
        /// values- V4_ONLY) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "auto_allocate_ip_type")]
        public string? AutoAllocateIpType { get; set; }
        /// <summary>
        /// Availability-zone to place the Virtual Service. Field introduced in 17.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// (internal-use) FIP allocated by Avi in the Cloud infrastructure. Field introduced in 17.1.1. Allowed in Basic(Allowed
        /// values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "avi_allocated_fip")]
        public bool? AviAllocatedFip { get; set; }
        /// <summary>
        /// (internal-use) VIP allocated by Avi in the Cloud infrastructure. Field introduced in 17.1.1. Allowed in Basic(Allowed
        /// values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "avi_allocated_vip")]
        public bool? AviAllocatedVip { get; set; }
        /// <summary>
        /// Discovered networks providing reachability for client facing Vip IP. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_networks")]
        public IList<NSXTALBDiscoveredNetworkType> DiscoveredNetworks { get; set; }
        /// <summary>
        /// Enable or disable the Vip. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Floating IPv4 to associate with this Vip. Field introduced in 17.1.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "floating_ip")]
        public NSXTALBIpAddrType FloatingIp { get; set; }
        /// <summary>
        /// Floating IPv6 address to associate with this Vip. Field introduced in 18.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "floating_ip6")]
        public NSXTALBIpAddrType FloatingIp6 { get; set; }
        /// <summary>
        /// If auto_allocate_floating_ip is True and more than one floating-ip subnets exist, then the subnet for the floating IPv6
        /// address allocation. Field introduced in 18.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "floating_subnet6_uuid")]
        public string? FloatingSubnet6Uuid { get; set; }
        /// <summary>
        /// If auto_allocate_floating_ip is True and more than one floating-ip subnets exist, then the subnet for the floating IP
        /// address allocation. Field introduced in 17.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "floating_subnet_uuid")]
        public string? FloatingSubnetUuid { get; set; }
        /// <summary>
        /// IPv6 Address of the Vip. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        public NSXTALBIpAddrType Ip6Address { get; set; }
        /// <summary>
        /// IPv4 Address of the VIP. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// Subnet and/or Network for allocating VirtualService IP by IPAM Provider module. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ipam_network_subnet")]
        public NSXTALBIPNetworkSubnetType IpamNetworkSubnet { get; set; }
        /// <summary>
        /// Manually override the network on which the Vip is placed. It is a reference to an object of type Network. Field
        /// introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// Placement networks/subnets to use for vip placement. Field introduced in 18.2.5. Maximum of 10 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "placement_networks")]
        public IList<NSXTALBVipPlacementNetworkType> PlacementNetworks { get; set; }
        /// <summary>
        /// (internal-use) Network port assigned to the Vip IP address. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "port_uuid")]
        public string? PortUuid { get; set; }
        /// <summary>
        /// Mask applied for the Vip, non-default mask supported only for wildcard Vip. Allowed values are 0-32. Field introduced in
        /// 20.1.1. Allowed in Basic(Allowed values- 32) edition, Essentials(Allowed values- 32) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length")]
        public int? PrefixLength { get; set; }
        /// <summary>
        /// Subnet providing reachability for client facing Vip IP. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// Subnet providing reachability for client facing Vip IPv6. Field introduced in 18.1.1. Allowed in Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
        /// <summary>
        /// If auto_allocate_ip is True, then the subnet for the Vip IPv6 address allocation. This field is applicable only if the
        /// VirtualService belongs to an Openstack or AWS cloud, in which case it is mandatory, if auto_allocate is selected. Field
        /// introduced in 18.1.1. Allowed in Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6_uuid")]
        public string? Subnet6Uuid { get; set; }
        /// <summary>
        /// If auto_allocate_ip is True, then the subnet for the Vip IP address allocation. This field is applicable only if the
        /// VirtualService belongs to an Openstack or AWS cloud, in which case it is mandatory, if auto_allocate is selected. Field
        /// introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_uuid")]
        public string? SubnetUuid { get; set; }
        /// <summary>
        /// Unique ID associated with the vip. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VipId { get; set; }
    }
}
