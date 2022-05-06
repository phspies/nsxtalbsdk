using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVirtualServiceResourcesScoreDataType
    {
        /// <summary>
        /// Resources of the virtual service with respect to max_throughput.
        /// </summary>
        [JsonProperty(PropertyName = "avg_bandwidth_usage")]
        public double? AvgBandwidthUsage { get; set; }
        /// <summary>
        /// Fraction of service engines available.
        /// </summary>
        [JsonProperty(PropertyName = "ha_index")]
        public double? HaIndex { get; set; }
        /// <summary>
        /// Resources of the virtual service with respect to max_open_conns.
        /// </summary>
        [JsonProperty(PropertyName = "max_open_conns_usage")]
        public double? MaxOpenConnsUsage { get; set; }
        /// <summary>
        /// Fraction of VIPs available, given a VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "multivip_index")]
        public double? MultivipIndex { get; set; }
        /// <summary>
        /// Placeholder for description of property pool_resources_scores of obj type VirtualServiceResourcesScoreData field type
        /// str  type object
        /// </summary>
        [JsonProperty(PropertyName = "pool_resources_scores")]
        public IList<NSXTALBPoolResourcesScoreType> PoolResourcesScores { get; set; }
        /// <summary>
        /// Reason for the Health Score.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Reason { get; set; }
        /// <summary>
        /// Attribute that is dominating the health score.
        /// </summary>
        [JsonProperty(PropertyName = "reason_attr")]
        public string? ReasonAttr { get; set; }
        /// <summary>
        /// It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string? Ref { get; set; }
        /// <summary>
        /// Placeholder for description of property serviceengine_resources_scores of obj type VirtualServiceResourcesScoreData
        /// field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_resources_scores")]
        public IList<NSXTALBServiceEngineResourcesScoreType> ServiceengineResourcesScores { get; set; }
    }
}
