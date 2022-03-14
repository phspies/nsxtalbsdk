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
    public class NSXTALBRouteInfoType 
    {
        public NSXTALBRouteInfoType()
        {
        }
        /// <summary>
        /// Host interface name. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// Network Namespace type used to add an route entry in a specific namespace. Enum options - LOCAL_NAMESPACE,
        /// HOST_NAMESPACE, OTHER_NAMESPACE. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "network_namespace")]
        public string? NetworkNamespace { get; set; }
        /// <summary>
        /// Host nexthop ip address. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "nexthop")]
        public NSXTALBIpAddrType Nexthop { get; set; }
        /// <summary>
        /// Host subnet address. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "subnet", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
    }
}
