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
    public class NSXTALBInternalGatewayMonitorType 
    {
        public NSXTALBInternalGatewayMonitorType()
        {
        }
        /// <summary>
        /// Disable the gateway monitor for default gateway. They are monitored by default. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "disable_gateway_monitor")]
        public bool? DisableGatewayMonitor { get; set; }
        /// <summary>
        /// The number of consecutive failed gateway health checks before a gateway is marked down. Allowed values are 3-50. Field
        /// introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_monitor_failure_threshold")]
        public int? GatewayMonitorFailureThreshold { get; set; }
        /// <summary>
        /// The interval between two ping requests sent by the gateway monitor in milliseconds. If a value is not specified,
        /// requests are sent every second. Allowed values are 100-60000. Field introduced in 17.1.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_monitor_interval")]
        public int? GatewayMonitorInterval { get; set; }
        /// <summary>
        /// The number of consecutive successful gateway health checks before a gateway that was marked down by the gateway monitor
        /// is marked up. Allowed values are 3-50. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_monitor_success_threshold")]
        public int? GatewayMonitorSuccessThreshold { get; set; }
    }
}
