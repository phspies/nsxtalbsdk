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
    public class NSXTALBGslbIpAddrType 
    {
        public NSXTALBGslbIpAddrType()
        {
        }
        /// <summary>
        /// Public IP address of the pool member. Field introduced in 17.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public NSXTALBIpAddrType Ip { get; set; }
    }
}
