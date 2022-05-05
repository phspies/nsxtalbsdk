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
    public class NSXTALBServerIdType 
    {
        /// <summary>
        /// This is the external cloud uuid of the Pool server.
        /// </summary>
        [JsonProperty(PropertyName = "external_uuid")]
        public string? ExternalUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property ip of obj type ServerId field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Number of port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Port { get; set; }
    }
}
