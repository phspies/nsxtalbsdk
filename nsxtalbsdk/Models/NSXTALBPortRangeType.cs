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
    public class NSXTALBPortRangeType 
    {
        /// <summary>
        /// TCP/UDP port range end (inclusive). Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        [System.ComponentModel.DataAnnotations.Required]
        public int End { get; set; }
        /// <summary>
        /// TCP/UDP port range start (inclusive). Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Start { get; set; }
    }
}
