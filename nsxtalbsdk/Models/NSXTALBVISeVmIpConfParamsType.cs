using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVISeVmIpConfParamsType
    {
        /// <summary>
        /// default_gw of VISeVmIpConfParams.
        /// </summary>
        [JsonProperty(PropertyName = "default_gw")]
        public string? DefaultGw { get; set; }
        /// <summary>
        /// mgmt_ip_addr of VISeVmIpConfParams.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_ip_addr")]
        public string? MgmtIpAddr { get; set; }
        /// <summary>
        /// Enum options - VNIC_IP_TYPE_DHCP, VNIC_IP_TYPE_STATIC.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_ip_type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MgmtIpType { get; set; }
        /// <summary>
        /// mgmt_net_mask of VISeVmIpConfParams.
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_net_mask")]
        public string? MgmtNetMask { get; set; }
    }
}
