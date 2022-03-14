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
    public class NSXTALBBotIdentificationType 
    {
        public NSXTALBBotIdentificationType()
        {
        }
        /// <summary>
        /// The Bot Client Class of this identification. Enum options - UNDETERMINED_CLIENT, HUMAN_CLIENT, BOT_CLIENT. Field
        /// introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "class")]
        public string? Class { get; set; }
        /// <summary>
        /// A free-form string to identify the client. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string? Identifier { get; set; }
        /// <summary>
        /// The Bot Client Type of this identification. Enum options - UNDETERMINED_CLIENT_TYPE, WEB_BROWSER, IN_APP_BROWSER,
        /// SEARCH_ENGINE, IMPERSONATOR, SPAM_SOURCE, WEB_ATTACKS, BOTNET, SCANNER, DENIAL_OF_SERVICE, CLOUD_SOURCE,
        /// SECURITY_SCANNER, SITE_MONITOR, GENERIC_APPLICATION. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
