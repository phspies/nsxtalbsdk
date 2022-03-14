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
    public class NSXTALBSensitiveFieldRuleType 
    {
        public NSXTALBSensitiveFieldRuleType()
        {
        }
        /// <summary>
        /// Action for the matched log field, for instance the matched field can be removed or masked off. Enum options -
        /// LOG_FIELD_REMOVE, LOG_FIELD_MASKOFF. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Enable rule to match the sensitive fields. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Index of the rule. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; set; }
        /// <summary>
        /// Criterion to use for matching in the Log. Field introduced in 17.2.10, 18.1.2. Allowed in Basic edition, Essentials
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBStringMatchType Match { get; set; }
        /// <summary>
        /// Name of the rule. Field introduced in 17.2.10, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
