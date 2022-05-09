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
    public class NSXTALBMemoryBalancerRequestType 
    {
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
        /// Current details regarding controller. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_info")]
        public NSXTALBControllerInfoType ControllerInfo { get; set; }
        /// <summary>
        /// Name of controller process. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// UUID of Node. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "node_uuid")]
        public string? NodeUuid { get; set; }
        /// <summary>
        /// Current process information of the controller process. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "process_info")]
        public NSXTALBProcessInfoType ProcessInfo { get; set; }
        /// <summary>
        /// Instance of the controller process. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "process_instance")]
        public string? ProcessInstance { get; set; }
        /// <summary>
        /// UUID of Tenant Object. It is a reference to an object of type Tenant. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Time at which Memory Balancer Request was created/updated. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// UUID of Memory Balancer Request object. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
