using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPRequestRuleType
    {
        /// <summary>
        /// Log all HTTP headers upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// Enable or disable the rule.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
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
        [JsonProperty(PropertyName = "index")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Index { get; set; }
        /// <summary>
        /// Log HTTP request upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public bool? Log { get; set; }
        /// <summary>
        /// Add match criteria to the rule.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// HTTP redirect action.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_action")]
        public NSXTALBHTTPRedirectActionType RedirectAction { get; set; }
        /// <summary>
        /// HTTP request URL rewrite action.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_url_action")]
        public NSXTALBHTTPRewriteURLActionType RewriteUrlAction { get; set; }
        /// <summary>
        /// Content switching action.
        /// </summary>
        [JsonProperty(PropertyName = "switching_action")]
        public NSXTALBHTTPSwitchingActionType SwitchingAction { get; set; }
    }
}
