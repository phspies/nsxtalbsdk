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
    public class NSXTALBFalsePositiveResultType 
    {
        public NSXTALBFalsePositiveResultType()
        {
        }
        /// <summary>
        /// Whether this URI is always fail. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "always_fail")]
        public bool? AlwaysFail { get; set; }
        /// <summary>
        /// This flag indicates whether this result is identifying an attack. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "attack")]
        public bool? Attack { get; set; }
        /// <summary>
        /// Confidence on false positive detection. Allowed values are 0-100. Field introduced in 21.1.1. Unit is PERCENT.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public double? Confidence { get; set; }
        /// <summary>
        /// This flag indicates whether this result is identifying a false positive. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "false_positive")]
        public bool? FalsePositive { get; set; }
        /// <summary>
        /// Header info if URI hit signature rule and match element is REQUEST_HEADERS. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "header_info")]
        public NSXTALBHeaderInfoInURIType HeaderInfo { get; set; }
        /// <summary>
        /// HTTP method for URIs did false positive detection. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_method")]
        public string? HttpMethod { get; set; }
        /// <summary>
        /// This flag indicates that system is not confident about this result. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "not_sure")]
        public bool? NotSure { get; set; }
        /// <summary>
        /// Params info if URI hit signature rule and match element is ARGS. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "params_info")]
        public NSXTALBParamsInURIType ParamsInfo { get; set; }
        /// <summary>
        /// Signature rule info hitted by URI. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rule_info")]
        public NSXTALBRuleInfoType RuleInfo { get; set; }
        /// <summary>
        /// Whether this URI is sometimes fail. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sometimes_fail")]
        public bool? SometimesFail { get; set; }
        /// <summary>
        /// URIs did false positive detection. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string? Uri { get; set; }
    }
}
