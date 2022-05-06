using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBStaticRouteType
    {
        /// <summary>
        /// Disable the gateway monitor for default gateway. They are monitored by default. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_gateway_monitor")]
        public bool? DisableGatewayMonitor { get; set; }
        /// <summary>
        /// if_name of StaticRoute.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// Labels associated with this route. Field introduced in 20.1.1. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Placeholder for description of property next_hop of obj type StaticRoute field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType NextHop { get; set; }
        /// <summary>
        /// Placeholder for description of property prefix of obj type StaticRoute field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrPrefixType Prefix { get; set; }
        /// <summary>
        /// route_id of StaticRoute.
        /// </summary>
        [JsonProperty(PropertyName = "route_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string RouteId { get; set; }
    }
}
