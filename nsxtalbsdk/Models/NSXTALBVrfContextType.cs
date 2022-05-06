using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVrfContextType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Key/value vrfcontext attributes. Field introduced in 20.1.2. Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "attrs")]
        public IList<NSXTALBKeyValueType> Attrs { get; set; }
        /// <summary>
        /// BFD configuration profile. Field introduced in 20.1.1. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_profile")]
        public NSXTALBBfdProfileType BfdProfile { get; set; }
        /// <summary>
        /// Bgp Local and Peer Info.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_profile")]
        public NSXTALBBgpProfileType BgpProfile { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Configure debug flags for VRF. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "debugvrfcontext")]
        public NSXTALBDebugVrfContextType Debugvrfcontext { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Configure ping based heartbeat check for gateway in service engines of vrf.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_mon")]
        public IList<NSXTALBGatewayMonitorType> GatewayMon { get; set; }
        /// <summary>
        /// Configure ping based heartbeat check for all default gateways in service engines of vrf. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "internal_gateway_monitor")]
        public NSXTALBInternalGatewayMonitorType InternalGatewayMonitor { get; set; }
        /// <summary>
        /// Key/value labels which can be used for Object Access Policy permission scoping. Field deprecated in 20.1.5. Field
        /// introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// Enable LLDP. Field introduced in 18.2.10, 20.1.1. Allowed in Basic(Allowed values- true) edition, Essentials(Allowed
        /// values- true) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "lldp_enable")]
        public bool? LldpEnable { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property static_routes of obj type VrfContext field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "static_routes")]
        public IList<NSXTALBStaticRouteType> StaticRoutes { get; set; }
        /// <summary>
        /// Placeholder for description of property system_default of obj type VrfContext field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "system_default")]
        public bool? SystemDefault { get; set; }
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
