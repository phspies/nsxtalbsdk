using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVipAutoscaleZonesType
    {
        /// <summary>
        /// Availability zone associated with the subnet. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        public string? AvailabilityZone { get; set; }
        /// <summary>
        /// Determines if the subnet is capable of hosting publicly accessible IP. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "fip_capable")]
        public bool? FipCapable { get; set; }
        /// <summary>
        /// UUID of the subnet for new IP address allocation. Field introduced in 17.2.12, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "subnet_uuid")]
        public string? SubnetUuid { get; set; }
    }
}
