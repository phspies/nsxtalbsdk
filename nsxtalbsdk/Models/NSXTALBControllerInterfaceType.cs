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
    public class NSXTALBControllerInterfaceType 
    {
        /// <summary>
        /// Default gateway of the mgmt interface. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "gateway")]
        public NSXTALBIpAddrType Gateway { get; set; }
        /// <summary>
        /// Interface name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// IP address of the interface. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrPrefixType Ip { get; set; }
        /// <summary>
        /// Interface label like mgmt, secure channel or HSM. Enum options - MGMT, SE_SECURE_CHANNEL, HSM. Field introduced in
        /// 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<string> Labels { get; set; }
        /// <summary>
        /// Mac address of interface. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// IP address mode DHCP/STATIC. Enum options - DHCP, STATIC, VIP, DOCKER_HOST. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Public IP of interface. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "public_ip_or_name")]
        public NSXTALBIpAddrType PublicIpOrName { get; set; }
    }
}
