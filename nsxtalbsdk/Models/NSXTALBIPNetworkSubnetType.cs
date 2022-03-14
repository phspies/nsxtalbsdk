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
    public class NSXTALBIPNetworkSubnetType 
    {
        /// <summary>
        /// Network for VirtualService IP allocation with Vantage as the IPAM provider. Network should be created before this is
        /// configured. It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// Subnet for VirtualService IP allocation with Vantage or Infoblox as the IPAM provider. Only one of subnet or subnet_uuid
        /// configuration is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// Subnet for VirtualService IPv6 allocation with Vantage or Infoblox as the IPAM provider. Only one of subnet or
        /// subnet_uuid configuration is allowed. Field introduced in 18.1.1. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public NSXTALBIpAddrPrefixType Subnet6 { get; set; }
        /// <summary>
        /// Subnet UUID or Name or Prefix for VirtualService IPv6 allocation with AWS or OpenStack as the IPAM provider. Only one of
        /// subnet or subnet_uuid configuration is allowed. Field introduced in 18.1.1. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6_uuid")]
        public string? Subnet6Uuid { get; set; }
        /// <summary>
        /// Subnet UUID or Name or Prefix for VirtualService IP allocation with AWS or OpenStack as the IPAM provider. Only one of
        /// subnet or subnet_uuid configuration is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_uuid")]
        public string? SubnetUuid { get; set; }
    }
}
