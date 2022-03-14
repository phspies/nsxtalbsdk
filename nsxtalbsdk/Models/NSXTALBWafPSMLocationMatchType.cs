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
    public class NSXTALBWafPSMLocationMatchType 
    {
        public NSXTALBWafPSMLocationMatchType()
        {
        }
        /// <summary>
        /// Apply the rules only to requests that match the specified Host header. If this is not set, the host header will not be
        /// checked. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public NSXTALBHostHdrMatchType Host { get; set; }
        /// <summary>
        /// Apply the rules only to requests that have the specified methods. If this is not set, the method will not be checked.
        /// Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "methods")]
        public NSXTALBMethodMatchType Methods { get; set; }
        /// <summary>
        /// Apply the rules only to requests that match the specified URI. If this is not set, the path will not be checked. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
    }
}
