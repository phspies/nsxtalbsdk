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
    public class NSXTALBNatMatchTargetType 
    {
        /// <summary>
        /// Destination IP of the packet. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ip")]
        public NSXTALBIpAddrMatchType DestinationIp { get; set; }
        /// <summary>
        /// Services like port-matching and protocol. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public NSXTALBServiceMatchType Services { get; set; }
        /// <summary>
        /// Source IP of the packet. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        public NSXTALBIpAddrMatchType SourceIp { get; set; }
    }
}
