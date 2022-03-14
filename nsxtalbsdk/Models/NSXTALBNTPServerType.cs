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
    public class NSXTALBNTPServerType 
    {
        public NSXTALBNTPServerType()
        {
        }
        /// <summary>
        /// Key number from the list of trusted keys used to authenticate this server. Allowed values are 1-65534.
        /// </summary>
        [JsonProperty(PropertyName = "key_number")]
        public int? KeyNumber { get; set; }
        /// <summary>
        /// IP Address of the NTP Server.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Server { get; set; }
    }
}
