using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPlacementNetworkType
    {
        /// <summary>
        /// It is a reference to an object of type Network.
        /// </summary>
        [JsonProperty(PropertyName = "network_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NetworkRef { get; set; }
        /// <summary>
        /// Placeholder for description of property subnet of obj type PlacementNetwork field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
    }
}
