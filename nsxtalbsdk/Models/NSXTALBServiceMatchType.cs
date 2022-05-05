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
    public class NSXTALBServiceMatchType 
    {
        /// <summary>
        /// Destination Port of the packet. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "destination_port")]
        public NSXTALBPortMatchType DestinationPort { get; set; }
        /// <summary>
        /// Protocol to match. Supported protocols are TCP, UDP and ICMP. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public NSXTALBL4RuleProtocolMatchType Protocol { get; set; }
        /// <summary>
        /// Source Port of the packet. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "source_port")]
        public NSXTALBPortMatchType SourcePort { get; set; }
    }
}
