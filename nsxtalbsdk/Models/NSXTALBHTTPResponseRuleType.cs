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
    public class NSXTALBHTTPResponseRuleType 
    {
        /// <summary>
        /// Log all HTTP headers upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// Enable or disable the rule.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enable { get; set; }
        /// <summary>
        /// HTTP header rewrite action.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_action")]
        public IList<NSXTALBHTTPHdrActionType> HdrAction { get; set; }
        /// <summary>
        /// Index of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Location header rewrite action.
        /// </summary>
        [JsonProperty(PropertyName = "loc_hdr_action")]
        public NSXTALBHTTPRewriteLocHdrActionType LocHdrAction { get; set; }
        /// <summary>
        /// Log HTTP request upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public bool? Log { get; set; }
        /// <summary>
        /// Add match criteria to the rule.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBResponseMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
