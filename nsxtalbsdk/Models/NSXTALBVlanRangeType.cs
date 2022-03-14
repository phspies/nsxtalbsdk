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
    public class NSXTALBVlanRangeType 
    {
        public NSXTALBVlanRangeType()
        {
        }
        /// <summary>
        /// Number of end.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int End { get; set; }
        /// <summary>
        /// Number of start.
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Start { get; set; }
    }
}
