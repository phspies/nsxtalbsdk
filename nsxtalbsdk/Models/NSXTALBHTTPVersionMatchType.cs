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
    public class NSXTALBHTTPVersionMatchType 
    {
        public NSXTALBHTTPVersionMatchType()
        {
        }
        /// <summary>
        /// Criterion to use for HTTP version matching the version used in the HTTP request. Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// HTTP protocol version. Enum options - ZERO_NINE, ONE_ZERO, ONE_ONE, TWO_ZERO. Minimum of 1 items required. Maximum of 8
        /// items allowed. Allowed in Basic(Allowed values- ONE_ZERO,ONE_ONE) edition, Essentials(Allowed values- ONE_ZERO,ONE_ONE)
        /// edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<string> Versions { get; set; }
    }
}
