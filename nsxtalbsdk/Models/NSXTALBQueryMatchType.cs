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
    public class NSXTALBQueryMatchType 
    {
        /// <summary>
        /// Case sensitivity to use for the match. Enum options - SENSITIVE, INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        public string? MatchCase { get; set; }
        /// <summary>
        /// Criterion to use for matching the query in HTTP request URI. Enum options - QUERY_MATCH_CONTAINS.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// String value(s).
        /// </summary>
        [JsonProperty(PropertyName = "match_str")]
        public IList<string> MatchStr { get; set; }
        /// <summary>
        /// UUID of the string group(s). It is a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_refs")]
        public IList<string> StringGroupRefs { get; set; }
    }
}
