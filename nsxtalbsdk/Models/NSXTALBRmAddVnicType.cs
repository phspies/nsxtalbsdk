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
    public class NSXTALBRmAddVnicType 
    {
        /// <summary>
        /// mac_addr associated with the network. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addr")]
        public string? MacAddr { get; set; }
        /// <summary>
        /// network_name of RmAddVnic.
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// Unique object identifier of network.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuid")]
        public string? NetworkUuid { get; set; }
        /// <summary>
        /// subnet of RmAddVnic.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string? Subnet { get; set; }
    }
}
