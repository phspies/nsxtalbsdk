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
    public class NSXTALBDnsAAAARdataType 
    {
        public NSXTALBDnsAAAARdataType()
        {
        }
        /// <summary>
        /// IPv6 address for FQDN. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_address", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip6Address { get; set; }
    }
}
