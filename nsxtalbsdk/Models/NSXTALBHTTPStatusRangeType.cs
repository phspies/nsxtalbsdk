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
    public class NSXTALBHTTPStatusRangeType 
    {
        /// <summary>
        /// Starting HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "begin", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Begin { get; set; }
        /// <summary>
        /// Ending HTTP response status code.
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int End { get; set; }
    }
}
