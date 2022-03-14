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
    public class NSXTALBUDPFastPathProfileType 
    {
        /// <summary>
        /// DSR profile information. Field introduced in 18.2.3. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dsr_profile")]
        public NSXTALBDsrProfileType DsrProfile { get; set; }
        /// <summary>
        /// When enabled, every UDP packet is considered a new transaction and may be load balanced to a different server.  When
        /// disabled, packets from the same client source IP and port are sent to the same server. Allowed in Basic(Allowed values-
        /// false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "per_pkt_loadbalance")]
        public bool? PerPktLoadbalance { get; set; }
        /// <summary>
        /// The amount of time (in sec) for which a flow needs to be idle before it is deleted. Allowed values are 2-3600. Unit is
        /// SEC.
        /// </summary>
        [JsonProperty(PropertyName = "session_idle_timeout")]
        public int? SessionIdleTimeout { get; set; }
        /// <summary>
        /// When disabled, Source NAT will not be performed for all client UDP packets.
        /// </summary>
        [JsonProperty(PropertyName = "snat")]
        public bool? Snat { get; set; }
    }
}
