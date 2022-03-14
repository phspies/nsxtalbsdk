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
    public class NSXTALBInventoryFaultConfigType 
    {
        public NSXTALBInventoryFaultConfigType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Configure controller faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "controller_faults")]
        public NSXTALBControllerFaultsType ControllerFaults { get; set; }
        /// <summary>
        /// Name. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Configure serviceengine faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "serviceengine_faults")]
        public NSXTALBServiceengineFaultsType ServiceengineFaults { get; set; }
        /// <summary>
        /// Tenant. It is a reference to an object of type Tenant. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID Auto generated. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Configure VirtualService faults. Field introduced in 20.1.6.
        /// </summary>
        [JsonProperty(PropertyName = "virtualservice_faults")]
        public NSXTALBVirtualserviceFaultsType VirtualserviceFaults { get; set; }
    }
}
