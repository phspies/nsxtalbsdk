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
    public class NSXTALBPropertyType 
    {
        public NSXTALBPropertyType()
        {
        }
        /// <summary>
        /// Property name. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Property value. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
