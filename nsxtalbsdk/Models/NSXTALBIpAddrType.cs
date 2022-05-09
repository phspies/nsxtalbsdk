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
    public class NSXTALBIpAddrType 
    {
        /// <summary>
        /// IP address.
        /// </summary>
        [JsonProperty(PropertyName = "addr")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Addr { get; set; }
        /// <summary>
        /// Enum options - V4, DNS, V6.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
