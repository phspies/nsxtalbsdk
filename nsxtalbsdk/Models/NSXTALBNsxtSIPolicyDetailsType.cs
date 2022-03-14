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
    public class NSXTALBNsxtSIPolicyDetailsType 
    {
        /// <summary>
        /// Error message. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// RedirectPolicy Path. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public string? Policy { get; set; }
        /// <summary>
        /// Traffic is redirected to this endpoints. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "redirectTo")]
        public IList<string> RedirectTo { get; set; }
        /// <summary>
        /// Policy scope. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// ServiceEngineGroup name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "segroup")]
        public string? Segroup { get; set; }
        /// <summary>
        /// Tier1 path. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tier1")]
        public string? Tier1 { get; set; }
    }
}
