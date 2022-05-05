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
    public class NSXTALBAzureNetworkInfoType 
    {
        /// <summary>
        /// Id of the Azure subnet used as management network for the Service Engines. If set, Service Engines will have a dedicated
        /// management NIC, otherwise, they operate in inband mode. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "management_network_id")]
        public string? ManagementNetworkId { get; set; }
        /// <summary>
        /// Id of the Azure subnet where Avi Controller will create the Service Engines. . Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "se_network_id")]
        public string? SeNetworkId { get; set; }
        /// <summary>
        /// Virtual network where Virtual IPs will belong. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_network_id")]
        public string? VirtualNetworkId { get; set; }
    }
}
