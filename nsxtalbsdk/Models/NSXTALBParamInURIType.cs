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
    public class NSXTALBParamInURIType 
    {
        public NSXTALBParamInURIType()
        {
        }
        /// <summary>
        /// Param name in hitted signature rule match_element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "param_name")]
        public string? ParamName { get; set; }
        /// <summary>
        /// Param value in hitted signature rule match_element. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
