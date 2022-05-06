using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHdrMatchType
    {
        /// <summary>
        /// Name of the HTTP header whose value is to be matched.
        /// </summary>
        [JsonProperty(PropertyName = "hdr")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Hdr { get; set; }
        /// <summary>
        /// Case sensitivity to use for the match. Enum options - SENSITIVE, INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        public string? MatchCase { get; set; }
        /// <summary>
        /// Criterion to use for matching headers in the HTTP request. Enum options - HDR_EXISTS, HDR_DOES_NOT_EXIST,
        /// HDR_BEGINS_WITH, HDR_DOES_NOT_BEGIN_WITH, HDR_CONTAINS, HDR_DOES_NOT_CONTAIN, HDR_ENDS_WITH, HDR_DOES_NOT_END_WITH,
        /// HDR_EQUALS, HDR_DOES_NOT_EQUAL.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// String values to match in the HTTP header.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }
    }
}
