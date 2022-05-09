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
    public class NSXTALBSeGatewayHeartbeatSuccessDetailsType 
    {
        /// <summary>
        /// IP address of gateway monitored.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GatewayIp { get; set; }
        /// <summary>
        /// Name of Virtual Routing Context in which this gateway is present.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_name")]
        public string? VrfName { get; set; }
        /// <summary>
        /// UUID of the Virtual Routing Context in which this gateway is present.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_uuid")]
        public string? VrfUuid { get; set; }
    }
}
