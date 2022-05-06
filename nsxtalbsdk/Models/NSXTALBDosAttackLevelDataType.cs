using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDosAttackLevelDataType
    {
        /// <summary>
        /// Placeholder for description of property avg_dos_total_req of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_dos_total_req")]
        public double? AvgDosTotalReq { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_total_connections of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_total_connections")]
        public double? AvgTotalConnections { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_application_dos_attacks of obj type DosAttackLevelData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "pct_application_dos_attacks")]
        public double? PctApplicationDosAttacks { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_connections_dos_attacks of obj type DosAttackLevelData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "pct_connections_dos_attacks")]
        public double? PctConnectionsDosAttacks { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_dos_bandwidth of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_dos_bandwidth")]
        public double? PctDosBandwidth { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_dos_rx_bytes of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_dos_rx_bytes")]
        public double? PctDosRxBytes { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_pkts_dos_attacks of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_pkts_dos_attacks")]
        public double? PctPktsDosAttacks { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_policy_drops of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_policy_drops")]
        public double? PctPolicyDrops { get; set; }
        /// <summary>
        /// Reason for the DoS Attack Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the DoS Attack Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property serviceengine_dos_attack_level_scores of obj type DosAttackLevelData field type
        /// str  type object
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_dos_attack_level_scores")]
        public IList<NSXTALBServiceEngineDosAttackLevelType> ServiceengineDosAttackLevelScores { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type DosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }
    }
}
