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
    public class NSXTALBPortMatchGenericType 
    {
        public NSXTALBPortMatchGenericType()
        {
        }
        /// <summary>
        /// Criterion to use for src/dest port in a TCP/UDP packet. Enum options - IS_IN, IS_NOT_IN. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
        /// <summary>
        /// Listening TCP port(s). Allowed values are 1-65535. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public int? Ports { get; set; }
        /// <summary>
        /// A port range defined by a start and end, including both. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ranges")]
        public IList<NSXTALBPortRangeType> Ranges { get; set; }
    }
}
