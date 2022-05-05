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
    public class NSXTALBFlowtableProfileType 
    {
        /// <summary>
        /// Idle timeout in seconds for ICMP flows. Allowed values are 1-36000. Field introduced in 20.1.3. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_idle_timeout")]
        public int? IcmpIdleTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for TCP flows in closed state. Allowed values are 1-36000. Field introduced in 18.2.5. Unit is
        /// SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_closed_timeout")]
        public int? TcpClosedTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for nat TCP flows in connection setup state. Allowed values are 1-36000. Field introduced in
        /// 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_connection_setup_timeout")]
        public int? TcpConnectionSetupTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for TCP flows in half closed state. Allowed values are 1-36000. Field introduced in 18.2.5. Unit
        /// is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_half_closed_timeout")]
        public int? TcpHalfClosedTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for TCP flows. Allowed values are 1-36000. Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_idle_timeout")]
        public int? TcpIdleTimeout { get; set; }
        /// <summary>
        /// Timeout in seconds for TCP flows after RST is seen.Within this timeout, if any non-syn packet is seenfrom the endpoint
        /// from which RST is received,nat-flow moves to established state. Otherwise nat-flowis cleaned up. This state helps to
        /// mitigate the impactof RST attacks. Allowed values are 1-36000. Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_reset_timeout")]
        public int? TcpResetTimeout { get; set; }
        /// <summary>
        /// Idle timeout in seconds for UDP flows. Allowed values are 1-36000. Field introduced in 18.2.5. Unit is SECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "udp_idle_timeout")]
        public int? UdpIdleTimeout { get; set; }
    }
}
