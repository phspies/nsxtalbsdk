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
    public class NSXTALBHostAttributesType 
    {
        /// <summary>
        /// attr_key of HostAttributes.
        /// </summary>
        [JsonProperty(PropertyName = "attr_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttrKey { get; set; }
        /// <summary>
        /// attr_val of HostAttributes.
        /// </summary>
        [JsonProperty(PropertyName = "attr_val")]
        public string? AttrVal { get; set; }
    }
}
