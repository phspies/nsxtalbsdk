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
    public class NSXTALBDnsARdataType 
    {
        public NSXTALBDnsARdataType()
        {
        }
        /// <summary>
        /// IP address for FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddress { get; set; }
    }
}
