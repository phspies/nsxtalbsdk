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
    public class NSXTALBPlacementNetworkType 
    {
        public NSXTALBPlacementNetworkType()
        {
        }
        /// <summary>
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NetworkRef { get; set; }
        /// <summary>
        /// Placeholder for description of property subnet of obj type PlacementNetwork field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
    }
}
