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
    public class NSXTALBHostHdrMatchType 
    {
        /// <summary>
        /// Case sensitivity to use for the match. Enum options - SENSITIVE, INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        public string? MatchCase { get; set; }
        /// <summary>
        /// Criterion to use for the host header value match. Enum options - HDR_EXISTS, HDR_DOES_NOT_EXIST, HDR_BEGINS_WITH,
        /// HDR_DOES_NOT_BEGIN_WITH, HDR_CONTAINS, HDR_DOES_NOT_CONTAIN, HDR_ENDS_WITH, HDR_DOES_NOT_END_WITH, HDR_EQUALS,
        /// HDR_DOES_NOT_EQUAL.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// String value(s) in the host header.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }
    }
}
