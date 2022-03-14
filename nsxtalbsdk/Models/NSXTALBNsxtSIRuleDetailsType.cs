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
    public class NSXTALBNsxtSIRuleDetailsType 
    {
        public NSXTALBNsxtSIRuleDetailsType()
        {
        }
        /// <summary>
        /// Rule Action. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Destinatios excluded or not. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "destexclude")]
        public bool? Destexclude { get; set; }
        /// <summary>
        /// Destination of redirection rule. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "dests")]
        public IList<string> Dests { get; set; }
        /// <summary>
        /// Rule Direction. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string? Direction { get; set; }
        /// <summary>
        /// Error message. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Pool name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string? Pool { get; set; }
        /// <summary>
        /// ServiceEngineGroup name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "segroup")]
        public string? Segroup { get; set; }
        /// <summary>
        /// Services of redirection rule. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// Sources of redirection rule. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<string> Sources { get; set; }
    }
}
