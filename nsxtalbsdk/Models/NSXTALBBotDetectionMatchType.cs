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
    public class NSXTALBBotDetectionMatchType 
    {
        public NSXTALBBotDetectionMatchType()
        {
        }
        /// <summary>
        /// Bot classification types. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "classifications")]
        public IList<NSXTALBBotClassificationType> Classifications { get; set; }
        /// <summary>
        /// Match criteria. Enum options - IS_IN, IS_NOT_IN. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_operation", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchOperation { get; set; }
    }
}
