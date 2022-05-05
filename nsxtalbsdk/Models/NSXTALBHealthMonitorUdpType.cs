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
    public class NSXTALBHealthMonitorUdpType 
    {
        /// <summary>
        /// Match or look for this keyword in the first 2KB of server's response indicating server maintenance.  A successful match
        /// results in the server being marked down.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_response")]
        public string? MaintenanceResponse { get; set; }
        /// <summary>
        /// Send UDP request.
        /// </summary>
        [JsonProperty(PropertyName = "udp_request")]
        public string? UdpRequest { get; set; }
        /// <summary>
        /// Match for keyword in the UDP response.
        /// </summary>
        [JsonProperty(PropertyName = "udp_response")]
        public string? UdpResponse { get; set; }
    }
}
