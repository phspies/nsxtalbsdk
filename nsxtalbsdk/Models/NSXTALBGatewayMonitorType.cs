using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBGatewayMonitorType
    {
        /// <summary>
        /// IP address of next hop gateway to be monitored.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType GatewayIp { get; set; }
        /// <summary>
        /// The number of consecutive failed gateway health checks before a gateway is marked down. Allowed values are 3-50.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_monitor_fail_threshold")]
        public int? GatewayMonitorFailThreshold { get; set; }
        /// <summary>
        /// The interval between two ping requests sent by the gateway monitor in milliseconds. If a value is not specified,
        /// requests are sent every second. Allowed values are 100-60000. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_monitor_interval")]
        public int? GatewayMonitorInterval { get; set; }
        /// <summary>
        /// The number of consecutive successful gateway health checks before a gateway that was marked down by the gateway monitor
        /// is marked up. Allowed values are 3-50.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_monitor_success_threshold")]
        public int? GatewayMonitorSuccessThreshold { get; set; }
        /// <summary>
        /// Subnet providing reachability for Multi-hop Gateway. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public NSXTALBIpAddrPrefixType Subnet { get; set; }
    }
}
