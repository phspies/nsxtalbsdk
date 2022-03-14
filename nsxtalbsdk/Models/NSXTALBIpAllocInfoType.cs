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
    public class NSXTALBIpAllocInfoType 
    {
        public NSXTALBIpAllocInfoType()
        {
        }
        /// <summary>
        /// Placeholder for description of property ip of obj type IpAllocInfo field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// mac of IpAllocInfo.
        /// </summary>
        [JsonProperty(PropertyName = "mac", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Mac { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeUuid { get; set; }
    }
}
