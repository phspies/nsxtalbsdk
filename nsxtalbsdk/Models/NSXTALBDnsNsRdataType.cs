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
    public class NSXTALBDnsNsRdataType 
    {
        public NSXTALBDnsNsRdataType()
        {
        }
        /// <summary>
        /// IPv6 address for Name Server. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address")]
        public NSXTALBIpAddrType Ip6Address { get; set; }
        /// <summary>
        /// IP address for Name Server. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// Name Server name. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsname", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Nsname { get; set; }
    }
}
