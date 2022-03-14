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
    public class NSXTALBNetworkType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Key/value network attributes. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "attrs")]
        public IList<NSXTALBKeyValueType> Attrs { get; set; }
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
        /// Placeholder for description of property configured_subnets of obj type Network field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "configured_subnets")]
        public IList<NSXTALBSubnetType> ConfiguredSubnets { get; set; }
        /// <summary>
        /// Select the IP address management scheme for this Network.
        /// </summary>
        [JsonProperty(PropertyName = "dhcp_enabled")]
        public bool? DhcpEnabled { get; set; }
        /// <summary>
        /// When selected, excludes all discovered subnets in this network from consideration for virtual service placement.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_discovered_subnets")]
        public bool? ExcludeDiscoveredSubnets { get; set; }
        /// <summary>
        /// Enable IPv6 auto configuration. Field introduced in 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip6_autocfg_enabled")]
        public bool? Ip6AutocfgEnabled { get; set; }
        /// <summary>
        /// Key/value labels which can be used for Object Access Policy permission scoping. Field deprecated in 20.1.5. Field
        /// introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueType> Labels { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC. Field introduced in 20.1.5. Allowed in Basic edition, Essentials edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Placeholder for description of property synced_from_se of obj type Network field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "synced_from_se")]
        public bool? SyncedFromSe { get; set; }
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
        /// Placeholder for description of property vcenter_dvs of obj type Network field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_dvs")]
        public bool? VcenterDvs { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrNWRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "vimgrnw_ref")]
        public string? VimgrnwRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_ref")]
        public string? VrfContextRef { get; set; }
    }
}
