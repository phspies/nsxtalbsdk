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
    public class NSXTALBStringMatchType 
    {
        public NSXTALBStringMatchType()
        {
        }
        /// <summary>
        /// Criterion to use for string matching the HTTP request. Enum options - BEGINS_WITH, DOES_NOT_BEGIN_WITH, CONTAINS,
        /// DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS, DOES_NOT_EQUAL, REGEX_MATCH, REGEX_DOES_NOT_MATCH. Allowed in
        /// Basic(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL) edition,
        /// Essentials(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
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
