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
    public class NSXTALBNetworkSubnetInfoType 
    {
        /// <summary>
        /// Number of free.
        /// </summary>
        [JsonProperty(PropertyName = "free")]
        public int? Free { get; set; }
        /// <summary>
        /// network_name of NetworkSubnetInfo.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// Unique object identifier of network.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuid")]
        public string? NetworkUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property subnet of obj type NetworkSubnetInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
        /// <summary>
        /// Number of total.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }
        /// <summary>
        /// Enum options - STATIC_IPS_FOR_SE, STATIC_IPS_FOR_VIP, STATIC_IPS_FOR_VIP_AND_SE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Number of used.
        /// </summary>
        [JsonProperty(PropertyName = "used")]
        public int? Used { get; set; }
    }
}
