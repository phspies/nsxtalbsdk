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
    public class NSXTALBHealthScoreAnomalyDataType 
    {
        public NSXTALBHealthScoreAnomalyDataType()
        {
        }
        /// <summary>
        /// Placeholder for description of property application_anomaly of obj type HealthScoreAnomalyData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "application_anomaly")]
        public NSXTALBApplicationAnomalyScoreDataType ApplicationAnomaly { get; set; }
        /// <summary>
        /// Placeholder for description of property controller_anomaly of obj type HealthScoreAnomalyData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "controller_anomaly")]
        public NSXTALBControllerAnomalyScoreDataType ControllerAnomaly { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_anomaly of obj type HealthScoreAnomalyData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_anomaly")]
        public NSXTALBPoolAnomalyScoreDataType PoolAnomaly { get; set; }
        /// <summary>
        /// Reason for Anomaly Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// reason_attr of HealthScoreAnomalyData.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// Placeholder for description of property server_anomaly of obj type HealthScoreAnomalyData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "server_anomaly")]
        public NSXTALBServerAnomalyScoreDataType ServerAnomaly { get; set; }
        /// <summary>
        /// Placeholder for description of property serviceengine_anomaly of obj type HealthScoreAnomalyData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_anomaly")]
        public NSXTALBServiceEngineAnomalyScoreDataType ServiceengineAnomaly { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type HealthScoreAnomalyData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
        /// <summary>
        /// Placeholder for description of property virtualservice_anomaly of obj type HealthScoreAnomalyData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice_anomaly")]
        public NSXTALBVirtualServiceAnomalyScoreDataType VirtualserviceAnomaly { get; set; }
    }
}
