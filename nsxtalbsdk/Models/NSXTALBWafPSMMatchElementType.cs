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
    public class NSXTALBWafPSMMatchElementType 
    {
        public NSXTALBWafPSMMatchElementType()
        {
        }
        /// <summary>
        /// Mark this element excluded, like in '!ARGS password'. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "excluded")]
        public bool? Excluded { get; set; }
        /// <summary>
        /// Match_element index. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Case sensitivity of match_op operation. Enum options - SENSITIVE, INSENSITIVE. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        public string? MatchCase { get; set; }
        /// <summary>
        /// String operation to use for matching the sub_element. Default is EQUALS. Enum options - BEGINS_WITH,
        /// DOES_NOT_BEGIN_WITH, CONTAINS, DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS, DOES_NOT_EQUAL, REGEX_MATCH,
        /// REGEX_DOES_NOT_MATCH. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_op")]
        public string? MatchOp { get; set; }
        /// <summary>
        /// The variable specification. For example ARGS or REQUEST_COOKIES. This can be a scalar like PATH_INFO. Enum options -
        /// WAF_VARIABLE_ARGS, WAF_VARIABLE_ARGS_GET, WAF_VARIABLE_ARGS_POST, WAF_VARIABLE_ARGS_NAMES, WAF_VARIABLE_REQUEST_COOKIES,
        /// WAF_VARIABLE_QUERY_STRING, WAF_VARIABLE_REQUEST_BASENAME, WAF_VARIABLE_REQUEST_URI, WAF_VARIABLE_PATH_INFO. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// The name of the request collection element. This can be empty, if we address the whole collection or a scalar element.
        /// Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sub_element")]
        public string? SubElement { get; set; }
    }
}
