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
    public class NSXTALBWafPSMLocationType 
    {
        /// <summary>
        /// Free-text comment about this location. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Location index, this is used to determine the order of the locations. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Apply these rules only if the request is matching this description. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBWafPSMLocationMatchType Match { get; set; }
        /// <summary>
        /// User defined name for this location, it must be unique in the group. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// A list of rules which should be applied on this location. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBWafPSMRuleType> Rules { get; set; }
    }
}
