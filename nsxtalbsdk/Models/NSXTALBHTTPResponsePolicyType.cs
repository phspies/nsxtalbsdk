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
    public class NSXTALBHTTPResponsePolicyType 
    {
        public NSXTALBHTTPResponsePolicyType()
        {
        }
        /// <summary>
        /// Add rules to the HTTP response policy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTALBHTTPResponseRuleType> Rules { get; set; }
    }
}
