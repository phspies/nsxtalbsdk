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
    public class NSXTALBJWTProfileApiResponseType 
    {
        public NSXTALBJWTProfileApiResponseType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "count", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTALBJWTProfileType> Results { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string? Next { get; set; }
    }
}
