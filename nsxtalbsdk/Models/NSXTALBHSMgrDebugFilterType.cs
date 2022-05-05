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
    public class NSXTALBHSMgrDebugFilterType 
    {
        /// <summary>
        /// entity of HSMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "entity")]
        public string? Entity { get; set; }
        /// <summary>
        /// Enum options - VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY, CONTROLLER_METRICS_ENTITY,
        /// APPLICATION_METRICS_ENTITY, TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metric_entity")]
        public string? MetricEntity { get; set; }
        /// <summary>
        /// Number of period.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public int? Period { get; set; }
        /// <summary>
        /// pool of HSMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string? Pool { get; set; }
        /// <summary>
        /// server of HSMgrDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Placeholder for description of property skip_hs_db_writes of obj type HSMgrDebugFilter field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "skip_hs_db_writes")]
        public bool? SkipHsDbWrites { get; set; }
    }
}
