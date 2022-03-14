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
    public class NSXTALBReplaceStringVarType 
    {
        public NSXTALBReplaceStringVarType()
        {
        }
        /// <summary>
        /// Type of replacement string - can be a variable exposed from datascript, value of an HTTP variable, a custom user-input
        /// literal string, or a string with all three combined. Enum options - DATASCRIPT_VAR, AVI_VAR, LITERAL_STRING,
        /// COMBINATION_STRING.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Value of the replacement string - name of variable exposed from datascript, name of the HTTP header, a custom user-input
        /// literal string, or a string with all three combined.
        /// </summary>
        [JsonProperty(PropertyName = "val")]
        public string? Val { get; set; }
    }
}
