using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBL4RuleProtocolMatchType
    {
        /// <summary>
        /// Criterion to use for transport protocol matching. Enum options - IS_IN, IS_NOT_IN. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Transport protocol to match. Enum options - PROTOCOL_ICMP, PROTOCOL_TCP, PROTOCOL_UDP. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
    }
}
