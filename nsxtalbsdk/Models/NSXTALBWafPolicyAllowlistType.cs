using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBWafPolicyAllowlistType
    {
        /// <summary>
        /// Rules to bypass WAF. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafPolicyAllowlistRuleType> Rules { get; set; }
    }
}
