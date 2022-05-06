using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDosAttackEventDetailsType
    {
        /// <summary>
        /// Enum options - LAND, SMURF, ICMP_PING_FLOOD, UNKOWN_PROTOCOL, TEARDROP, IP_FRAG_OVERRUN, IP_FRAG_TOOSMALL, IP_FRAG_FULL,
        /// IP_FRAG_INCOMPLETE, PORT_SCAN, TCP_NON_SYN_FLOOD_OLD, SYN_FLOOD, BAD_RST_FLOOD, MALFORMED_FLOOD, FAKE_SESSION,
        /// ZERO_WINDOW_STRESS, SMALL_WINDOW_STRESS, DOS_HTTP_TIMEOUT, DOS_HTTP_ERROR, DOS_HTTP_ABORT, DOS_SSL_ERROR, DOS_APP_ERROR,
        /// DOS_REQ_IP_RL_DROP, DOS_REQ_URI_RL_DROP, DOS_REQ_URI_SCAN_BAD_RL_DROP, DOS_REQ_URI_SCAN_UNKNOWN_RL_DROP,
        /// DOS_REQ_IP_URI_RL_DROP, DOS_CONN_IP_RL_DROP, DOS_SLOW_URL, TCP_NON_SYN_FLOOD, DOS_REQ_CIP_SCAN_BAD_RL_DROP,
        /// DOS_REQ_CIP_SCAN_UNKNOWN_RL_DROP, DOS_REQ_IP_RL_DROP_BAD, DOS_REQ_URI_RL_DROP_BAD, DOS_REQ_IP_URI_RL_DROP_BAD,
        /// POLICY_DROPS, DOS_CONN_RL_DROP, DOS_REQ_RL_DROP, DOS_REQ_HDR_RL_DROP, DOS_REQ_CUSTOM_RL_DROP, DNS_ATTACK_REFLECTION,
        /// DNS_ATTACK_AMPLIFICATION_EGRESS, TCP_SLOW_AND_LOW, DNS_ATTACK_NXDOMAIN.
        /// </summary>
        [JsonProperty(PropertyName = "attack")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Attack { get; set; }
        /// <summary>
        /// Placeholder for description of property attack_count of obj type DosAttackEventDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "attack_count")]
        [System.ComponentModel.DataAnnotations.Required]
        public double AttackCount { get; set; }
        /// <summary>
        /// Unique object identifiers of ipgroups.
        /// </summary>
        [JsonProperty(PropertyName = "ipgroup_uuids")]
        public IList<string> IpgroupUuids { get; set; }
        /// <summary>
        /// Placeholder for description of property meta_data of obj type DosAttackEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "meta_data")]
        public IList<NSXTALBAttackMetaDataType> MetaData { get; set; }
        /// <summary>
        /// src_ips of DosAttackEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "src_ips")]
        public IList<string> SrcIps { get; set; }
        /// <summary>
        /// urls of DosAttackEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }
    }
}
