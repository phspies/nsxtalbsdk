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
    public class NSXTALBWafApplicationSignatureAppVersionType 
    {
        /// <summary>
        /// Name of an application in the rule set. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public string? Application { get; set; }
        /// <summary>
        /// The last version of the rule set when the rules corresponding to the application changed. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_changed_ruleset_version")]
        public string? LastChangedRulesetVersion { get; set; }
        /// <summary>
        /// The number of rules available for this application. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "number_of_rules")]
        public int? NumberOfRules { get; set; }
    }
}
