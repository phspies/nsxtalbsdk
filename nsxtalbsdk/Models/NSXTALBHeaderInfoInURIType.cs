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
    public class NSXTALBHeaderInfoInURIType 
    {
        /// <summary>
        /// Header field name in hitted signature rule match_element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "header_field_name")]
        public string? HeaderFieldName { get; set; }
        /// <summary>
        /// Header field value in hitted signature rule match_element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
