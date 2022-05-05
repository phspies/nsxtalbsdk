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
    public class NSXTALBWafExclusionTypeType 
    {
        /// <summary>
        /// Case sensitivity to use for the matching. Enum options - SENSITIVE, INSENSITIVE. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCase { get; set; }
        /// <summary>
        /// String Operation to use for matching the Exclusion. Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,
        /// DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS, DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH. Field
        /// introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "match_op")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchOp { get; set; }
    }
}
