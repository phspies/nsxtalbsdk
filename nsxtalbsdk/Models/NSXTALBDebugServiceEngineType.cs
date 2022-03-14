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
    public class NSXTALBDebugServiceEngineType 
    {
        public NSXTALBDebugServiceEngineType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Action to be invoked at configured layer. Enum options - SE_BENCHMARK_MODE_DROP, SE_BENCHMARK_MODE_REFLECT. Field
        /// introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "benchmark_action")]
        public string? BenchmarkAction { get; set; }
        /// <summary>
        /// Toggle and configure the layer to benchmark performance. This can be done at a specific point in the SE packet
        /// processing pipeline. Enum options - SE_BENCHMARK_LAYER_NONE, SE_BENCHMARK_LAYER_POST_VNIC_RX,
        /// SE_BENCHMARK_LAYER_POST_FT_LOOKUP, SE_BENCHMARK_LAYER_NSP_LOOKUP, SE_BENCHMARK_LAYER_PRE_PROXY_PUNT,
        /// SE_BENCHMARK_LAYER_POST_PROXY_PUNT, SE_BENCHMARK_LAYER_ETHER_INPUT, SE_BENCHMARK_LAYER_IP_INPUT,
        /// SE_BENCHMARK_LAYER_UDP_INPUT, SE_BENCHMARK_LAYER_POST_L2_PROCESSING. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "benchmark_layer")]
        public string? BenchmarkLayer { get; set; }
        /// <summary>
        /// Configure different reflect modes. Enum options - SE_BENCHMARK_REFLECT_SWAP_L4, SE_BENCHMARK_REFLECT_SWAP_L2,
        /// SE_BENCHMARK_REFLECT_SWAP_L3. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "benchmark_option")]
        public string? BenchmarkOption { get; set; }
        /// <summary>
        /// RSS Hash function to be used for packet reflect in TX path. Enum options - SE_BENCHMARK_DISABLE_HASH,
        /// SE_BENCHMARK_RTE_SOFT_HASH. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "benchmark_rss_hash")]
        public string? BenchmarkRssHash { get; set; }
        /// <summary>
        /// Enable/disable packet capture. Field introduced in 18.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "capture")]
        public bool? Capture { get; set; }
        /// <summary>
        /// Per packet capture filters for Debug Service Engine. Not applicable for DOS pcap capture. . Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "capture_filters")]
        public NSXTALBCaptureFiltersType CaptureFilters { get; set; }
        /// <summary>
        /// Params for SE pcap. Field introduced in 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "capture_params")]
        public NSXTALBDebugVirtualServiceCaptureType CaptureParams { get; set; }
        /// <summary>
        /// Placeholder for description of property cpu_shares of obj type DebugServiceEngine field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "cpu_shares")]
        public IList<NSXTALBDebugSeCpuSharesType> CpuShares { get; set; }
        /// <summary>
        /// Per packet IP filter for Service Engine PCAP. Matches with source and destination address. Field introduced in
        /// 17.2.14,18.1.5,18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "debug_ip")]
        public NSXTALBDebugIpAddrType DebugIp { get; set; }
        /// <summary>
        /// Enables the use of kdump on SE. Requires SE Reboot. Applicable only in case of VM Based deployments. Field introduced in
        /// 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enable_kdump")]
        public bool? EnableKdump { get; set; }
        /// <summary>
        /// Params for SE fault injection. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "fault")]
        public NSXTALBDebugSeFaultType Fault { get; set; }
        /// <summary>
        /// Placeholder for description of property flags of obj type DebugServiceEngine field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public IList<NSXTALBDebugSeDataplaneType> Flags { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property seagent_debug of obj type DebugServiceEngine field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "seagent_debug")]
        public IList<NSXTALBDebugSeAgentType> SeagentDebug { get; set; }
        /// <summary>
        /// Debug knob for se_log_agent process. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "selogagent_debug")]
        public NSXTALBDebugSeAgentType SelogagentDebug { get; set; }
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
    }
}
