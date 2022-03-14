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
    public class NSXTALBDnsOptRecordType 
    {
        public NSXTALBDnsOptRecordType()
        {
        }
        /// <summary>
        /// Flag indicating client is DNSSEC aware. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dnssec_ok")]
        public bool? DnssecOk { get; set; }
        /// <summary>
        /// EDNS options. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IList<NSXTALBDnsEdnsOptionType> Options { get; set; }
        /// <summary>
        /// Client requestor's UDP payload size. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "udp_payload_size")]
        public int? UdpPayloadSize { get; set; }
        /// <summary>
        /// EDNS version. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }
    }
}
