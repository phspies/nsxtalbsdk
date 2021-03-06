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
    public class NSXTALBVIGuestvNicIPAddrType 
    {
        /// <summary>
        /// ip_addr of VIGuestvNicIPAddr.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addr")]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpAddr { get; set; }
        /// <summary>
        /// Number of mask.
        /// </summary>
        [JsonProperty(PropertyName = "mask")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Mask { get; set; }
    }
}
