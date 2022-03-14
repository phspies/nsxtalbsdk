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
    public class NSXTALBJWTMatchType 
    {
        public NSXTALBJWTMatchType()
        {
        }
        /// <summary>
        /// Claims whose values need to be matched. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "matches")]
        public IList<NSXTALBJWTClaimMatchType> Matches { get; set; }
        /// <summary>
        /// Token for which the claims need to be validated. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "token_name")]
        public string? TokenName { get; set; }
    }
}
