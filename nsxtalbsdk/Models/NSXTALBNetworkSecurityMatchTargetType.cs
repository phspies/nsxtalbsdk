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
    public class NSXTALBNetworkSecurityMatchTargetType 
    {
        /// <summary>
        /// Placeholder for description of property client_ip of obj type NetworkSecurityMatchTarget field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// Matches the source port of incoming packets in the client side traffic. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_port")]
        public NSXTALBPortMatchGenericType ClientPort { get; set; }
        /// <summary>
        /// Matches the geo information of incoming packets in the client side traffic. Field introduced in 21.1.1. Maximum of 1
        /// items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "geo_matches")]
        public IList<NSXTALBGeoMatchType> GeoMatches { get; set; }
        /// <summary>
        /// Field introduced in 20.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_type")]
        public NSXTALBIPReputationTypeMatchType IpReputationType { get; set; }
        /// <summary>
        /// Placeholder for description of property microservice of obj type NetworkSecurityMatchTarget field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "microservice")]
        public NSXTALBMicroServiceMatchType Microservice { get; set; }
        /// <summary>
        /// Placeholder for description of property vs_port of obj type NetworkSecurityMatchTarget field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vs_port")]
        public NSXTALBPortMatchType VsPort { get; set; }
    }
}
