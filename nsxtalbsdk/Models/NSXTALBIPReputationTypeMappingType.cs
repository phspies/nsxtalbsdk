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
    public class NSXTALBIPReputationTypeMappingType 
    {
        public NSXTALBIPReputationTypeMappingType()
        {
        }
        /// <summary>
        /// The Bot Identification to which the IP reputation type is mapped. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "bot_identification", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBBotIdentificationType BotIdentification { get; set; }
        /// <summary>
        /// The type of IP reputation that is mapped to a Bot Identification. Enum options - IP_REPUTATION_TYPE_SPAM_SOURCE,
        /// IP_REPUTATION_TYPE_WINDOWS_EXPLOITS, IP_REPUTATION_TYPE_WEB_ATTACKS, IP_REPUTATION_TYPE_BOTNETS,
        /// IP_REPUTATION_TYPE_SCANNERS, IP_REPUTATION_TYPE_DOS, IP_REPUTATION_TYPE_REPUTATION, IP_REPUTATION_TYPE_PHISHING,
        /// IP_REPUTATION_TYPE_PROXY, IP_REPUTATION_TYPE_NETWORK, IP_REPUTATION_TYPE_CLOUD, IP_REPUTATION_TYPE_MOBILE_THREATS,
        /// IP_REPUTATION_TYPE_TOR, IP_REPUTATION_TYPE_ALL. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_reputation_type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string IpReputationType { get; set; }
    }
}
