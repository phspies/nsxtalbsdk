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
    public class NSXTALBL4RuleProtocolMatchType 
    {
        public NSXTALBL4RuleProtocolMatchType()
        {
        }
        /// <summary>
        /// Criterion to use for transport protocol matching. Enum options - IS_IN, IS_NOT_IN. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Transport protocol to match. Enum options - PROTOCOL_ICMP, PROTOCOL_TCP, PROTOCOL_UDP. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
    }
}
