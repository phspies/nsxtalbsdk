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
    public class NSXTALBHealthMonitorTcpType 
    {
        /// <summary>
        /// Match or look for this keyword in the first 2KB of server's response indicating server maintenance.  A successful match
        /// results in the server being marked down.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_response")]
        public string? MaintenanceResponse { get; set; }
        /// <summary>
        /// Configure TCP health monitor to use half-open TCP connections to monitor the health of backend servers thereby avoiding
        /// consumption of a full fledged server side connection and the overhead and logs associated with it.  This method is
        /// light-weight as it makes use of listener in server's kernel layer to measure the health and a child socket or user
        /// thread is not created on the server side. Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values-
        /// false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_half_open")]
        public bool? TcpHalfOpen { get; set; }
        /// <summary>
        /// Request data to send after completing the TCP handshake.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_request")]
        public string? TcpRequest { get; set; }
        /// <summary>
        /// Match for the desired keyword in the first 2Kb of the server's TCP response. If this field is left blank, no server
        /// response is required.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_response")]
        public string? TcpResponse { get; set; }
    }
}
