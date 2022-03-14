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
    public class NSXTALBKeyValueTupleType 
    {
        public NSXTALBKeyValueTupleType()
        {
        }
        /// <summary>
        /// Key. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Key { get; set; }
        /// <summary>
        /// Value. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
