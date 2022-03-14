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
    public class NSXTALBHTTPHdrDataType 
    {
        public NSXTALBHTTPHdrDataType()
        {
        }
        /// <summary>
        /// HTTP header name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// HTTP header value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public NSXTALBHTTPHdrValueType Value { get; set; }
    }
}
