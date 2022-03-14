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
    public class NSXTALBMatchReplacePairType 
    {
        /// <summary>
        /// String to be matched. Field deprecated in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_string")]
        public string? MatchString { get; set; }
        /// <summary>
        /// Replacement string. Field deprecated in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "replacement_string")]
        public NSXTALBReplaceStringVarType ReplacementString { get; set; }
    }
}
