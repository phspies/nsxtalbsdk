using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDosThresholdType
    {
        /// <summary>
        /// Attack type. Enum options - LAND, SMURF, ICMP_PING_FLOOD, UNKOWN_PROTOCOL, TEARDROP, IP_FRAG_OVERRUN, IP_FRAG_TOOSMALL,
        /// IP_FRAG_FULL, IP_FRAG_INCOMPLETE, PORT_SCAN, TCP_NON_SYN_FLOOD_OLD, SYN_FLOOD, BAD_RST_FLOOD, MALFORMED_FLOOD,
        /// FAKE_SESSION, ZERO_WINDOW_STRESS, SMALL_WINDOW_STRESS, DOS_HTTP_TIMEOUT, DOS_HTTP_ERROR, DOS_HTTP_ABORT, DOS_SSL_ERROR,
        /// DOS_APP_ERROR, DOS_REQ_IP_RL_DROP, DOS_REQ_URI_RL_DROP, DOS_REQ_URI_SCAN_BAD_RL_DROP, DOS_REQ_URI_SCAN_UNKNOWN_RL_DROP,
        /// DOS_REQ_IP_URI_RL_DROP, DOS_CONN_IP_RL_DROP, DOS_SLOW_URL, TCP_NON_SYN_FLOOD, DOS_REQ_CIP_SCAN_BAD_RL_DROP,
        /// DOS_REQ_CIP_SCAN_UNKNOWN_RL_DROP, DOS_REQ_IP_RL_DROP_BAD, DOS_REQ_URI_RL_DROP_BAD, DOS_REQ_IP_URI_RL_DROP_BAD,
        /// POLICY_DROPS, DOS_CONN_RL_DROP, DOS_REQ_RL_DROP, DOS_REQ_HDR_RL_DROP, DOS_REQ_CUSTOM_RL_DROP, DNS_ATTACK_REFLECTION,
        /// DNS_ATTACK_AMPLIFICATION_EGRESS, TCP_SLOW_AND_LOW, DNS_ATTACK_NXDOMAIN.
        /// </summary>
        [JsonProperty(PropertyName = "attack")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Attack { get; set; }
        /// <summary>
        /// Maximum number of packets or connections or requests in a given interval of time to be deemed as attack.
        /// </summary>
        [JsonProperty(PropertyName = "max_value")]
        [System.ComponentModel.DataAnnotations.Required]
        public int MaxValue { get; set; }
        /// <summary>
        /// Minimum number of packets or connections or requests in a given interval of time to be deemed as attack.
        /// </summary>
        [JsonProperty(PropertyName = "min_value")]
        [System.ComponentModel.DataAnnotations.Required]
        public int MinValue { get; set; }
    }
}
