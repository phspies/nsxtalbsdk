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
    public class NSXTALBServiceEngineDosAttackLevelDataType 
    {
        public NSXTALBServiceEngineDosAttackLevelDataType()
        {
        }
        /// <summary>
        /// Placeholder for description of property avg_connections of obj type ServiceEngineDosAttackLevelData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_connections")]
        public double? AvgConnections { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_rx_bandwidth of obj type ServiceEngineDosAttackLevelData field type str 
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "avg_rx_bandwidth")]
        public double? AvgRxBandwidth { get; set; }
        /// <summary>
        /// Placeholder for description of property avg_rx_pkts of obj type ServiceEngineDosAttackLevelData field type str  type
        /// number
        /// </summary>
        [JsonProperty(PropertyName = "avg_rx_pkts")]
        public double? AvgRxPkts { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_connections_dropped of obj type ServiceEngineDosAttackLevelData field type
        /// str  type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_connections_dropped")]
        public double? PctConnectionsDropped { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_rx_bytes_dropped of obj type ServiceEngineDosAttackLevelData field type str 
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_rx_bytes_dropped")]
        public double? PctRxBytesDropped { get; set; }
        /// <summary>
        /// Placeholder for description of property pct_rx_pkts_dropped of obj type ServiceEngineDosAttackLevelData field type str 
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "pct_rx_pkts_dropped")]
        public double? PctRxPktsDropped { get; set; }
        /// <summary>
        /// Reason for the SE DoS Attack Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the DoS Attack Level.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type ServiceEngineDosAttackLevelData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }
    }
}
