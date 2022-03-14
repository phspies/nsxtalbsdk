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
    public class NSXTALBCloneServerType 
    {
        public NSXTALBCloneServerType()
        {
        }
        /// <summary>
        /// IP Address of the Clone Server. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// MAC Address of the Clone Server. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// Network to clone the traffic to. It is a reference to an object of type Network. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        public string? NetworkRef { get; set; }
        /// <summary>
        /// Subnet of the network to clone the traffic to. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
    }
}
