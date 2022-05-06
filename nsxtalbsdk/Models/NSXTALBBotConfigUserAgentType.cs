using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBBotConfigUserAgentType
    {
        /// <summary>
        /// Whether User Agent-based Bot detection is enabled. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
