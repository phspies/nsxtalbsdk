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
    public class NSXTALBRmSeIpFailEventDetailsType 
    {
        public NSXTALBRmSeIpFailEventDetailsType()
        {
        }
        /// <summary>
        /// host_name of RmSeIpFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "host_name")]
        public string? HostName { get; set; }
        /// <summary>
        /// Placeholder for description of property networks of obj type RmSeIpFailEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<NSXTALBRmAddVnicType> Networks { get; set; }
        /// <summary>
        /// reason of RmSeIpFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// se_name of RmSeIpFailEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
    }
}
