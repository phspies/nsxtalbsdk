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
    public class NSXTALBCustomTagType 
    {
        /// <summary>
        /// tag_key of CustomTag.
        /// </summary>
        [JsonProperty(PropertyName = "tag_key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TagKey { get; set; }
        /// <summary>
        /// tag_val of CustomTag.
        /// </summary>
        [JsonProperty(PropertyName = "tag_val")]
        public string? TagVal { get; set; }
    }
}
