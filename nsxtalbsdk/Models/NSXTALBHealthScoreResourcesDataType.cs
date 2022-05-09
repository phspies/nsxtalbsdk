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
    public class NSXTALBHealthScoreResourcesDataType 
    {
        /// <summary>
        /// Placeholder for description of property application_resources of obj type HealthScoreResourcesData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "application_resources")]
        public NSXTALBApplicationResourcesScoreDataType ApplicationResources { get; set; }
        /// <summary>
        /// Placeholder for description of property controller_resources of obj type HealthScoreResourcesData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "controller_resources")]
        public NSXTALBControllerResourcesScoreDataType ControllerResources { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_resources of obj type HealthScoreResourcesData field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_resources")]
        public NSXTALBPoolResourcesScoreDataType PoolResources { get; set; }
        /// <summary>
        /// Reason for Resources Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// reason_attr of HealthScoreResourcesData.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// Placeholder for description of property server_resources of obj type HealthScoreResourcesData field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "server_resources")]
        public NSXTALBServerResourcesScoreDataType ServerResources { get; set; }
        /// <summary>
        /// Placeholder for description of property serviceengine_resources of obj type HealthScoreResourcesData field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_resources")]
        public NSXTALBServiceEngineResourcesScoreDataType ServiceengineResources { get; set; }
        /// <summary>
        /// Placeholder for description of property value of obj type HealthScoreResourcesData field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        [System.ComponentModel.DataAnnotations.Required]
        public double Value { get; set; }
        /// <summary>
        /// Placeholder for description of property virtualservice_resources of obj type HealthScoreResourcesData field type str 
        /// type object
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice_resources")]
        public NSXTALBVirtualServiceResourcesScoreDataType VirtualserviceResources { get; set; }
    }
}
