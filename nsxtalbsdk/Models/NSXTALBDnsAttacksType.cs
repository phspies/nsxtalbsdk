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
    public class NSXTALBDnsAttacksType 
    {
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only, or detect and mitigate the attacks. Field introduced in
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "attacks")]
        public IList<NSXTALBDnsAttackType> Attacks { get; set; }
        /// <summary>
        /// Mode of dealing with the attacks - perform detection only, or detect and mitigate the attacks. Enum options - DETECTION,
        /// MITIGATION. Field introduced in 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "oper_mode")]
        public string? OperMode { get; set; }
    }
}
