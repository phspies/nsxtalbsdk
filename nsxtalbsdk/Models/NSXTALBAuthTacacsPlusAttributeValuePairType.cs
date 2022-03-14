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
    public class NSXTALBAuthTacacsPlusAttributeValuePairType 
    {
        public NSXTALBAuthTacacsPlusAttributeValuePairType()
        {
        }
        /// <summary>
        /// mandatory.
        /// </summary>
        [JsonProperty(PropertyName = "mandatory")]
        public bool? Mandatory { get; set; }
        /// <summary>
        /// attribute name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// attribute value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
