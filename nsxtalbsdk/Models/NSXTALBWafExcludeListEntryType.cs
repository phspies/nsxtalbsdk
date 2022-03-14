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
    public class NSXTALBWafExcludeListEntryType 
    {
        /// <summary>
        /// Client IP Subnet to exclude for WAF rules. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "client_subnet")]
        public NSXTALBIpAddrPrefixType ClientSubnet { get; set; }
        /// <summary>
        /// Free-text comment about this exclusion. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The match_element can be 'ARGS xxx', 'ARGS_GET xxx', 'ARGS_POST xxx', 'ARGS_NAMES xxx', 'FILES xxx', 'QUERY_STRING',
        /// 'REQUEST_BASENAME', 'REQUEST_BODY', 'REQUEST_URI', 'REQUEST_URI_RAW', 'REQUEST_COOKIES xxx', 'REQUEST_HEADERS xxx',
        /// 'RESPONSE_HEADERS xxx' or XML xxx. These match_elements in the HTTP Transaction (if present) will be excluded when
        /// executing WAF Rules. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_element")]
        public string? MatchElement { get; set; }
        /// <summary>
        /// Criteria for match_element matching. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "match_element_criteria")]
        public NSXTALBWafExclusionTypeType MatchElementCriteria { get; set; }
        /// <summary>
        /// Criteria for URI matching. Field introduced in 17.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "uri_match_criteria")]
        public NSXTALBWafExclusionTypeType UriMatchCriteria { get; set; }
        /// <summary>
        /// URI Path to exclude for WAF rules. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "uri_path")]
        public string? UriPath { get; set; }
    }
}
