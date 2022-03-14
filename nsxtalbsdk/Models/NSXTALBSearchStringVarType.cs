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
    public class NSXTALBSearchStringVarType 
    {
        /// <summary>
        /// Type of search string - can be a variable exposed from datascript, value of an HTTP variable, a custom user-input
        /// literal string, or a regular expression. Enum options - SEARCH_DATASCRIPT_VAR, SEARCH_AVI_VAR, SEARCH_LITERAL_STRING,
        /// SEARCH_REGEX. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Value of search string - can be a variable exposed from datascript, value of an HTTP variable, a custom user-input
        /// literal string, or a regular expression. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "val", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Val { get; set; }
    }
}
