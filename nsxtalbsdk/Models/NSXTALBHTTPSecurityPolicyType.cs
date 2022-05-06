using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPSecurityPolicyType
    {
        /// <summary>
        /// Add rules to the HTTP security policy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBHTTPSecurityRuleType> Rules { get; set; }
    }
}
