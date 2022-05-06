using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
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
