using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPortMatchType
    {
        /// <summary>
        /// Criterion to use for port matching the HTTP request. Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Listening TCP port(s). Allowed values are 1-65535. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public int? Ports { get; set; }
    }
}
