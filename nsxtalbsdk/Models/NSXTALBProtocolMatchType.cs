using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBProtocolMatchType
    {
        /// <summary>
        /// Criterion to use for protocol matching the HTTP request. Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// HTTP or HTTPS protocol. Enum options - HTTP, HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocols { get; set; }
    }
}
