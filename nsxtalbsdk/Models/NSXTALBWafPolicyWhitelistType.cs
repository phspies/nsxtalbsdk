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
    public class NSXTALBWafPolicyWhitelistType 
    {
        /// <summary>
        /// Rules to bypass WAF. Field deprecated in 20.1.3. Field introduced in 18.2.3. Maximum of 1024 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafPolicyWhitelistRuleType> Rules { get; set; }
    }
}
