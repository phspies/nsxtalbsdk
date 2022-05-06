using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBotAllowListType
    {
        /// <summary>
        /// Allow rules to control which requests undergo BOT detection. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBBotAllowRuleType> Rules { get; set; }
    }
}
