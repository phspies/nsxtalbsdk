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
    public class NSXTALBWafRuleMatchDataType 
    {
        public NSXTALBWafRuleMatchDataType()
        {
        }
        /// <summary>
        /// The match_element is an internal variable. It is not possible to add exclusions for this element. Field introduced in
        /// 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "is_internal")]
        public bool? IsInternal { get; set; }
        /// <summary>
        /// Field from a transaction that matches the rule, for instance if the request parameter is password=foobar, then
        /// match_element is ARGS password. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_element")]
        public string? MatchElement { get; set; }
        /// <summary>
        /// Value for a field from a transaction that matches the rule, for instance if the request parameter is password=foobar,
        /// then match_value is foobar. Field introduced in 17.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_value")]
        public string? MatchValue { get; set; }
    }
}
