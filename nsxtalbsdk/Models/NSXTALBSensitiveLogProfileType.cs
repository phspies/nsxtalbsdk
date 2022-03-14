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
    public class NSXTALBSensitiveLogProfileType 
    {
        public NSXTALBSensitiveLogProfileType()
        {
        }
        /// <summary>
        /// Match sensitive header fields in HTTP application log. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "header_field_rules")]
        public IList<NSXTALBSensitiveFieldRuleType> HeaderFieldRules { get; set; }
        /// <summary>
        /// Match sensitive URI query params in HTTP application log. Query params from the URI are extracted and checked for
        /// matching sensitive parameter names. A successful match will mask the parameter values in accordance with this rule
        /// action. Field introduced in 20.1.7, 21.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "uri_query_field_rules")]
        public IList<NSXTALBSensitiveFieldRuleType> UriQueryFieldRules { get; set; }
        /// <summary>
        /// Match sensitive WAF log fields in HTTP application log. Field introduced in 17.2.13, 18.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "waf_field_rules")]
        public IList<NSXTALBSensitiveFieldRuleType> WafFieldRules { get; set; }
    }
}
