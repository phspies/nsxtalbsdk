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
    public class NSXTALBIpAddrRangeType 
    {
        /// <summary>
        /// Starting IP address of the range.
        /// </summary>
        [JsonProperty(PropertyName = "begin")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Begin { get; set; }
        /// <summary>
        /// Ending IP address of the range.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType End { get; set; }
    }
}
