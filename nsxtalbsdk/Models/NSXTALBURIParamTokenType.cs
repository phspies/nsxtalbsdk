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
    public class NSXTALBURIParamTokenType 
    {
        /// <summary>
        /// Index of the ending token in the incoming URI. Allowed values are 0-65534. Special values are 65535 - end of string.
        /// </summary>
        [JsonProperty(PropertyName = "end_index")]
        public int? EndIndex { get; set; }
        /// <summary>
        /// Index of the starting token in the incoming URI.
        /// </summary>
        [JsonProperty(PropertyName = "start_index")]
        public int? StartIndex { get; set; }
        /// <summary>
        /// Constant string to use as a token.
        /// </summary>
        [JsonProperty(PropertyName = "str_value")]
        public string? StrValue { get; set; }
        /// <summary>
        /// Token type for constructing the URI. Enum options - URI_TOKEN_TYPE_HOST, URI_TOKEN_TYPE_PATH, URI_TOKEN_TYPE_STRING,
        /// URI_TOKEN_TYPE_STRING_GROUP, URI_TOKEN_TYPE_REGEX.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
