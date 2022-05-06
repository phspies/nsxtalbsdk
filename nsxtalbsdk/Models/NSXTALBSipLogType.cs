using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSipLogType
    {
        /// <summary>
        /// Server connection protocol type. Enum options - PROTOCOL_ICMP, PROTOCOL_TCP, PROTOCOL_UDP. Field introduced in 17.2.12,
        /// 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "server_protocol")]
        public string? ServerProtocol { get; set; }
        /// <summary>
        /// SIP CallId header. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_callid_hdr")]
        public string? SipCallidHdr { get; set; }
        /// <summary>
        /// Client's SIP Contact header. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_contact_hdr")]
        public string? SipContactHdr { get; set; }
        /// <summary>
        /// SIP From header. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_from_hdr")]
        public string? SipFromHdr { get; set; }
        /// <summary>
        /// SIP Messages. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_messages")]
        public IList<NSXTALBSipMessageType> SipMessages { get; set; }
        /// <summary>
        /// SIP To header. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "sip_to_hdr")]
        public string? SipToHdr { get; set; }
    }
}
