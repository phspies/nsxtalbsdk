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
    public class NSXTALBDnsQueryNameMatchType 
    {
        /// <summary>
        /// Criterion to use for string matching the DNS query domain name in the question section. Enum options - BEGINS_WITH,
        /// DOES_NOT_BEGIN_WITH, CONTAINS, DOES_NOT_CONTAIN, ENDS_WITH, DOES_NOT_END_WITH, EQUALS, DOES_NOT_EQUAL, REGEX_MATCH,
        /// REGEX_DOES_NOT_MATCH. Field introduced in 17.1.1. Allowed in Basic(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL) edition,
        /// Essentials(Allowed values-
        /// BEGINS_WITH,DOES_NOT_BEGIN_WITH,CONTAINS,DOES_NOT_CONTAIN,ENDS_WITH,DOES_NOT_END_WITH,EQUALS,DOES_NOT_EQUAL) edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Domain name to match against that specified in the question section of the DNS query. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "query_domain_names")]
        public IList<string> QueryDomainNames { get; set; }
        /// <summary>
        /// UUID of the string group(s) for matching against DNS query domain name in the question section. It is a reference to an
        /// object of type StringGroup. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "string_group_refs")]
        public IList<string> StringGroupRefs { get; set; }
    }
}
