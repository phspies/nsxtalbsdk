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
    public class NSXTALBHealthScoreSecurityDataType 
    {
        public NSXTALBHealthScoreSecurityDataType()
        {
        }
        /// <summary>
        /// Threat associated with VirtualService DoS infrastructure.
        /// </summary>
        [JsonProperty(PropertyName = "dos_attack_level_data")]
        public NSXTALBDosAttackLevelDataType DosAttackLevelData { get; set; }
        /// <summary>
        /// Reason for Security Threat Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string? Reason { get; set; }
        /// <summary>
        /// reason_attr of HealthScoreSecurityData.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// Threat associated with ServiceEngine DoS infrastructure.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_dos_attack_level_data")]
        public NSXTALBServiceEngineDosAttackLevelDataType ServiceengineDosAttackLevelData { get; set; }
        /// <summary>
        /// Threat associated with VirtualService SSL infrastructure.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_score_data")]
        public NSXTALBSslScoreDataType SslScoreData { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type HealthScoreSecurityData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }
    }
}
