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
    public class NSXTALBMesosMetricsDebugFilterType 
    {
        /// <summary>
        /// mesos_master of MesosMetricsDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "mesos_master")]
        public string? MesosMaster { get; set; }
        /// <summary>
        /// mesos_slave of MesosMetricsDebugFilter.
        /// </summary>
        [JsonProperty(PropertyName = "mesos_slave")]
        public string? MesosSlave { get; set; }
        /// <summary>
        /// Enum options - VSERVER_METRICS_ENTITY, VM_METRICS_ENTITY, SE_METRICS_ENTITY, CONTROLLER_METRICS_ENTITY,
        /// APPLICATION_METRICS_ENTITY, TENANT_METRICS_ENTITY, POOL_METRICS_ENTITY.
        /// </summary>
        [JsonProperty(PropertyName = "metric_entity")]
        public string? MetricEntity { get; set; }
        /// <summary>
        /// Number of metrics_collection_frq.
        /// </summary>
        [JsonProperty(PropertyName = "metrics_collection_frq")]
        public int? MetricsCollectionFrq { get; set; }
    }
}
