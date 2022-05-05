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
    public class NSXTALBDnsRuleRLActionType 
    {
        /// <summary>
        /// Type of action to be enforced upon hitting the rate limit. Enum options - DNS_RL_ACTION_NONE, DNS_RL_ACTION_DROP_REQ.
        /// Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
