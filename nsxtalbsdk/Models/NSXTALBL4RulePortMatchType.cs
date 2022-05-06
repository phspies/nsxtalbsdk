using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBL4RulePortMatchType
    {
        /// <summary>
        /// Criterion to use for Virtual Service port matching. Enum options - IS_IN, IS_NOT_IN. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Range of TCP/UDP port numbers of the Virtual Service. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "port_ranges")]
        public IList<NSXTALBPortRangeType> PortRanges { get; set; }
        /// <summary>
        /// Virtual Service's listening port(s). Allowed values are 1-65535. Field introduced in 17.2.7.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public int? Ports { get; set; }
    }
}
