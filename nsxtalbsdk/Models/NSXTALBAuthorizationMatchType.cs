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
    public class NSXTALBAuthorizationMatchType 
    {
        /// <summary>
        /// Access Token claims to be matched. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public NSXTALBJWTMatchType AccessToken { get; set; }
        /// <summary>
        /// Attributes whose values need to be matched . Field introduced in 18.2.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "attr_matches")]
        public IList<NSXTALBAuthAttributeMatchType> AttrMatches { get; set; }
        /// <summary>
        /// Host header value to be matched. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "host_hdr")]
        public NSXTALBHostHdrMatchType HostHdr { get; set; }
        /// <summary>
        /// HTTP methods to be matched. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public NSXTALBMethodMatchType Method { get; set; }
        /// <summary>
        /// Paths/URLs to be matched. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBPathMatchType Path { get; set; }
    }
}
