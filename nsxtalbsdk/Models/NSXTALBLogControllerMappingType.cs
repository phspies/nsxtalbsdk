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
    public class NSXTALBLogControllerMappingType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// controller_ip of LogControllerMapping.
        /// </summary>
        [JsonProperty(PropertyName = "controller_ip")]
        public string? ControllerIp { get; set; }
        /// <summary>
        /// Enum options - METRICS_MGR_PORT_0, METRICS_MGR_PORT_1, METRICS_MGR_PORT_2, METRICS_MGR_PORT_3.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_mgr_port")]
        public string? MetricsMgrPort { get; set; }
        /// <summary>
        /// Unique object identifier of node.
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// prev_controller_ip of LogControllerMapping.
        /// </summary>
        [JsonProperty(PropertyName = "prev_controller_ip")]
        public string? PrevControllerIp { get; set; }
        /// <summary>
        /// Enum options - METRICS_MGR_PORT_0, METRICS_MGR_PORT_1, METRICS_MGR_PORT_2, METRICS_MGR_PORT_3.
        /// </summary>
        [JsonProperty(PropertyName = "prev_metrics_mgr_port")]
        public string? PrevMetricsMgrPort { get; set; }
        /// <summary>
        /// Placeholder for description of property static_mapping of obj type LogControllerMapping field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "static_mapping")]
        public bool? StaticMapping { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
