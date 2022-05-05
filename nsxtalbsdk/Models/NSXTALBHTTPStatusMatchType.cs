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
    public class NSXTALBHTTPStatusMatchType 
    {
        /// <summary>
        /// Criterion to use for matching the HTTP response status code(s). Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// HTTP response status code range(s).
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBHTTPStatusRangeType> Ranges { get; set; }
        /// <summary>
        /// HTTP response status code(s).
        /// </summary>
        [JsonProperty(PropertyName = "status_codes")]
        public int? StatusCodes { get; set; }
    }
}
