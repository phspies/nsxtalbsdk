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
    public class NSXTALBMicroServiceMatchType 
    {
        /// <summary>
        /// UUID of Micro Service group(s). It is a reference to an object of type MicroServiceGroup.
        /// </summary>
        [JsonProperty(PropertyName = "group_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string GroupRef { get; set; }
        /// <summary>
        /// Criterion to use for Micro Service matching the HTTP request. Enum options - IS_IN, IS_NOT_IN.
        /// </summary>
        [JsonProperty(PropertyName = "match_criteria")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchCriteria { get; set; }
    }
}
