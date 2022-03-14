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
    public class NSXTALBTCPFastPathProfileType 
    {
        /// <summary>
        /// DSR profile information. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dsr_profile")]
        public NSXTALBDsrProfileType DsrProfile { get; set; }
        /// <summary>
        /// When enabled, Avi will complete the 3-way handshake with the client before forwarding any packets to the server.  This
        /// will protect the server from SYN flood and half open SYN connections. Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enable_syn_protection")]
        public bool? EnableSynProtection { get; set; }
        /// <summary>
        /// The amount of time (in sec) for which a connection needs to be idle before it is eligible to be deleted. Allowed values
        /// are 5-14400. Special values are 0 - infinite. Unit is SEC.
        /// </summary>
        [JsonProperty(PropertyName = "session_idle_timeout")]
        public int? SessionIdleTimeout { get; set; }
    }
}
