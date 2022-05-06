using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBContentRewriteProfileType
    {
        /// <summary>
        /// Strings to be matched and replaced with on the request body. This should be configured when request_rewrite_enabled is
        /// set to true. This is currently not supported. Field deprecated in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "req_match_replace_pair")]
        public IList<NSXTALBMatchReplacePairType> ReqMatchReplacePair { get; set; }
        /// <summary>
        /// Enable rewrite on request body. This is not currently supported. Field deprecated in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "request_rewrite_enabled")]
        public bool? RequestRewriteEnabled { get; set; }
        /// <summary>
        /// Enable rewrite on response body. Field deprecated in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "response_rewrite_enabled")]
        public bool? ResponseRewriteEnabled { get; set; }
        /// <summary>
        /// Rewrite only content types listed in this string group. Content types not present in this list are not rewritten. It is
        /// a reference to an object of type StringGroup.
        /// </summary>
        [JsonProperty(PropertyName = "rewritable_content_ref")]
        public string? RewritableContentRef { get; set; }
        /// <summary>
        /// Strings to be matched and replaced with on the response body. This should be configured when response_rewrite_enabled is
        /// set to true. Field deprecated in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rsp_match_replace_pair")]
        public IList<NSXTALBMatchReplacePairType> RspMatchReplacePair { get; set; }
        /// <summary>
        /// Content Rewrite rules to be enabled on theresponse body. Field introduced in 21.1.3. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "rsp_rewrite_rules")]
        public IList<NSXTALBRspContentRewriteRuleType> RspRewriteRules { get; set; }
    }
}
