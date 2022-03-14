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
    public class NSXTALBIPReputationTypeMatchType 
    {
        /// <summary>
        /// Match criteria. Enum options - IS_IN, IS_NOT_IN. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "match_operation", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string MatchOperation { get; set; }
        /// <summary>
        /// IP reputation type. Enum options - IP_REPUTATION_TYPE_SPAM_SOURCE, IP_REPUTATION_TYPE_WINDOWS_EXPLOITS,
        /// IP_REPUTATION_TYPE_WEB_ATTACKS, IP_REPUTATION_TYPE_BOTNETS, IP_REPUTATION_TYPE_SCANNERS, IP_REPUTATION_TYPE_DOS,
        /// IP_REPUTATION_TYPE_REPUTATION, IP_REPUTATION_TYPE_PHISHING, IP_REPUTATION_TYPE_PROXY, IP_REPUTATION_TYPE_NETWORK,
        /// IP_REPUTATION_TYPE_CLOUD, IP_REPUTATION_TYPE_MOBILE_THREATS, IP_REPUTATION_TYPE_TOR, IP_REPUTATION_TYPE_ALL. Field
        /// introduced in 20.1.1. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "reputation_types")]
        public IList<string> ReputationTypes { get; set; }
    }
}
