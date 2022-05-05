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
    public class NSXTALBAuthorizationPolicyType 
    {
        /// <summary>
        /// Authorization Policy Rules. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "authz_rules")]
        public IList<NSXTALBAuthorizationRuleType> AuthzRules { get; set; }
    }
}
