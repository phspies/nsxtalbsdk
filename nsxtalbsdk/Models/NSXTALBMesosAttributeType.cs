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
    public class NSXTALBMesosAttributeType 
    {
        /// <summary>
        /// Attribute to match.
        /// </summary>
        [JsonProperty(PropertyName = "attribute", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Attribute { get; set; }
        /// <summary>
        /// Attribute value. If not set, match any value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
