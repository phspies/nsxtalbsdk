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
    public class NSXTALBTestSeDatastoreLevel2ApiResponseType 
    {
        public NSXTALBTestSeDatastoreLevel2ApiResponseType()
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
        public IList<NSXTALBTestSeDatastoreLevel2Type> Results { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string? Next { get; set; }
    }
}
