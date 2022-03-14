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
    public class NSXTALBDnsAttackType 
    {
        public NSXTALBDnsAttackType()
        {
        }
        /// <summary>
        /// The DNS attack vector. Enum options - DNS_REFLECTION, DNS_NXDOMAIN, DNS_AMPLIFICATION_EGRESS. Field introduced in
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "attack_vector", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string AttackVector { get; set; }
        /// <summary>
        /// Enable or disable the mitigation of the attack vector. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Time in minutes after which mitigation will be deactivated. Allowed values are 1-4294967295. Special values are 0-
        /// blocked for ever. Field introduced in 18.2.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "max_mitigation_age")]
        public int? MaxMitigationAge { get; set; }
        /// <summary>
        /// Mitigation action to perform for this DNS attack vector. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "mitigation_action")]
        public NSXTALBAttackMitigationActionType MitigationAction { get; set; }
        /// <summary>
        /// Threshold, in terms of DNS packet per second, for the DNS attack vector. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public long? Threshold { get; set; }
    }
}
