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
    public class NSXTALBDiscoveredNetworkType 
    {
        /// <summary>
        /// Discovered network for this IP. It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NetworkRef { get; set; }
        /// <summary>
        /// Discovered subnet for this IP.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public IList<NSXTALBIpAddrPrefixType> Subnet { get; set; }
        /// <summary>
        /// Discovered IPv6 subnet for this IP. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet6")]
        public IList<NSXTALBIpAddrPrefixType> Subnet6 { get; set; }
    }
}
