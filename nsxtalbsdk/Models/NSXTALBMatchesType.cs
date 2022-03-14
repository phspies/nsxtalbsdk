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
    public class NSXTALBMatchesType 
    {
        /// <summary>
        /// Matches in signature rule. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_element")]
        public string? MatchElement { get; set; }
        /// <summary>
        /// Match value in signature rule. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_value")]
        public string? MatchValue { get; set; }
    }
}
