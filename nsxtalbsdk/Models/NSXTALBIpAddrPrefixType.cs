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
    public class NSXTALBIpAddrPrefixType 
    {
        /// <summary>
        /// Placeholder for description of property ip_addr of obj type IpAddrPrefix field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddr { get; set; }
        /// <summary>
        /// Number of mask.
        /// </summary>
        [JsonProperty(PropertyName = "mask", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Mask { get; set; }
    }
}
