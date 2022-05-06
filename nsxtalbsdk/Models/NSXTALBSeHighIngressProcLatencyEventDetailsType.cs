using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeHighIngressProcLatencyEventDetailsType
    {
        /// <summary>
        /// Dispatcher core which received the packet.
        /// </summary>
        [JsonProperty(PropertyName = "dispatcher_core")]
        public int? DispatcherCore { get; set; }
        /// <summary>
        /// Dispatcher processing latency. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "dispatcher_latency_ingress")]
        public int? DispatcherLatencyIngress { get; set; }
        /// <summary>
        /// Number of events in a 30 second interval.
        /// </summary>
        [JsonProperty(PropertyName = "event_count")]
        public long? EventCount { get; set; }
        /// <summary>
        /// Proxy core which processed the packet.
        /// </summary>
        [JsonProperty(PropertyName = "flow_core")]
        public int? FlowCore { get; set; }
        /// <summary>
        /// Proxy dequeue latency. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_latency_ingress")]
        public int? ProxyLatencyIngress { get; set; }
        /// <summary>
        /// SE name. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// SE UUID. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
        /// <summary>
        /// VS name. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// VS UUID. It is a reference to an object of type VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "vs_ref")]
        public string? VsRef { get; set; }
    }
}
