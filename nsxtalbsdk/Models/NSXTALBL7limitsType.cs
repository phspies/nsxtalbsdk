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
    public class NSXTALBL7limitsType 
    {
        /// <summary>
        /// Number of HTTPPolicies attached to a VS. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_policies_per_vs")]
        public int? HttpPoliciesPerVs { get; set; }
        /// <summary>
        /// Number of Compression Filters. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_compression_filters")]
        public int? NumCompressionFilters { get; set; }
        /// <summary>
        /// Number of Custom strings per match/action. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_custom_str")]
        public int? NumCustomStr { get; set; }
        /// <summary>
        /// Number of Matches per Rule. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_matches_per_rule")]
        public int? NumMatchesPerRule { get; set; }
        /// <summary>
        /// Number of rules per HTTPRequest/HTTPResponse/HTTPSecurity Policy. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_rules_per_http_policy")]
        public int? NumRulesPerHttpPolicy { get; set; }
        /// <summary>
        /// Number of Stringgroups/IPgroups per match. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "num_strgroups_per_match")]
        public int? NumStrgroupsPerMatch { get; set; }
        /// <summary>
        /// Number of implicit strings for Cacheable MIME types. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "str_cache_mime")]
        public int? StrCacheMime { get; set; }
        /// <summary>
        /// Number of String groups for Cacheable MIME types. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "str_groups_cache_mime")]
        public int? StrGroupsCacheMime { get; set; }
        /// <summary>
        /// Number of String groups for non Cacheable MIME types. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "str_groups_no_cache_mime")]
        public int? StrGroupsNoCacheMime { get; set; }
        /// <summary>
        /// Number of String groups for non Cacheable URI. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "str_groups_no_cache_uri")]
        public int? StrGroupsNoCacheUri { get; set; }
        /// <summary>
        /// Number of implicit strings for non Cacheable MIME types. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "str_no_cache_mime")]
        public int? StrNoCacheMime { get; set; }
        /// <summary>
        /// Number of implicit strings for non Cacheable URI. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "str_no_cache_uri")]
        public int? StrNoCacheUri { get; set; }
    }
}
