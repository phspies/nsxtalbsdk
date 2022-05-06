using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBAwsZoneConfigType
    {
        /// <summary>
        /// Availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "availability_zone")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AvailabilityZone { get; set; }
        /// <summary>
        /// Name or CIDR of the network in the Availability Zone that will be used as management network.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MgmtNetworkName { get; set; }
        /// <summary>
        /// UUID of the network in the Availability Zone that will be used as management network.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_network_uuid")]
        public string? MgmtNetworkUuid { get; set; }
    }
}
