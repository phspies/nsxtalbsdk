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
    public class NSXTALBServicePoolSelectorType 
    {
        /// <summary>
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "service_pool_group_ref")]
        public string? ServicePoolGroupRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "service_pool_ref")]
        public string? ServicePoolRef { get; set; }
        /// <summary>
        /// Pool based destination port. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "service_port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int ServicePort { get; set; }
        /// <summary>
        /// The end of the Service port number range. Allowed values are 1-65535. Special values are 0- single port. Field
        /// introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "service_port_range_end")]
        public int? ServicePortRangeEnd { get; set; }
        /// <summary>
        /// Destination protocol to match for the pool selection. If not specified, it will match any protocol. Enum options -
        /// PROTOCOL_TYPE_TCP_PROXY, PROTOCOL_TYPE_TCP_FAST_PATH, PROTOCOL_TYPE_UDP_FAST_PATH, PROTOCOL_TYPE_UDP_PROXY.
        /// </summary>
        [JsonProperty(PropertyName = "service_protocol")]
        public string? ServiceProtocol { get; set; }
    }
}
