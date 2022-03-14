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
    public class NSXTALBBotTypeMatcherType 
    {
        /// <summary>
        /// The list of client types. Enum options - UNDETERMINED_CLIENT_TYPE, WEB_BROWSER, IN_APP_BROWSER, SEARCH_ENGINE,
        /// IMPERSONATOR, SPAM_SOURCE, WEB_ATTACKS, BOTNET, SCANNER, DENIAL_OF_SERVICE, CLOUD_SOURCE, SECURITY_SCANNER,
        /// SITE_MONITOR, GENERIC_APPLICATION. Field introduced in 21.1.1. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "client_types")]
        public IList<string> ClientTypes { get; set; }
        /// <summary>
        /// The match operation. Enum options - IS_IN, IS_NOT_IN. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "op")]
        public string? Op { get; set; }
    }
}
