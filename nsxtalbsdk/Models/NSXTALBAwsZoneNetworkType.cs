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
    public class NSXTALBAwsZoneNetworkType 
    {
        /// <summary>
        /// Availability zone. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AvailabilityZone { get; set; }
        /// <summary>
        /// Usable networks for Virtual IP. If VirtualService does not specify a network and auto_allocate_ip is set, then the first
        /// available network from this list will be chosen for IP allocation. Field introduced in 17.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "usable_network_uuids")]
        public IList<string> UsableNetworkUuids { get; set; }
    }
}
