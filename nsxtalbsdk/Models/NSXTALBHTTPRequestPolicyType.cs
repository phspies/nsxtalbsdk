using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPRequestPolicyType
    {
        /// <summary>
        /// Add rules to the HTTP request policy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBHTTPRequestRuleType> Rules { get; set; }
    }
}
