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
    public class NSXTALBRspContentRewriteRuleType 
    {
        /// <summary>
        /// Enable rewrite rule on response body. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Index of the response rewrite rule. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; set; }
        /// <summary>
        /// Name of the response rewrite rule. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// List of search-and-replace string pairs for the response body. For eg. Strings 'foo' and 'bar', where all searches of
        /// 'foo' in the response body will be replaced with 'bar'. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pairs")]
        public IList<NSXTALBSearchReplacePairType> Pairs { get; set; }
    }
}
