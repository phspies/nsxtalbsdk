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
    public class NSXTALBVsVipType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Select BGP peers, using peer label, for VsVip advertisement. Field introduced in 20.1.5. Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_peer_labels")]
        public IList<string> BgpPeerLabels { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_ref")]
        public string? CloudRef { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// Service discovery specific data including fully qualified domain name, type and Time-To-Live of the DNS record. Field
        /// introduced in 17.1.1. Maximum of 1000 items allowed. Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public IList<NSXTALBDnsInfoType> DnsInfo { get; set; }
        /// <summary>
        /// Force placement on all Service Engines in the Service Engine Group (Container clouds only). Field introduced in 17.1.1.
        /// Allowed in Basic(Allowed values- false) edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_placement")]
        public bool? EastWestPlacement { get; set; }
        /// <summary>
        /// Determines the set of IPAM networks to use for this VsVip. Selector type must be SELECTOR_IPAM and only one label is
        /// supported. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ipam_selector")]
        public NSXTALBSelectorType IpamSelector { get; set; }
        /// <summary>
        /// Key value pairs for granular object access control. Also allows for classification and tagging of similar objects. Field
        /// deprecated in 20.1.5. Field introduced in 20.1.2. Maximum of 4 items allowed.
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
        /// Name for the VsVip object. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// This sets the placement scope of virtualservice to given tier1 logical router in Nsx-t. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_lr")]
        public string? Tier1Lr { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// This overrides the cloud level default and needs to match the SE Group value in which it will be used if the SE Group
        /// use_standard_alb value is set. This is only used when FIP is used for VS on Azure Cloud. Field introduced in 18.2.3.
        /// Allowed in Basic edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "use_standard_alb")]
        public bool? UseStandardAlb { get; set; }
        /// <summary>
        /// UUID of the VsVip object. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// List of Virtual Service IPs and other shareable entities. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public IList<NSXTALBVipType> Vip { get; set; }
        /// <summary>
        /// Virtual Routing Context that the Virtual Service is bound to. This is used to provide the isolation of the set of
        /// networks the application is attached to. It is a reference to an object of type VrfContext. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_ref")]
        public string? VrfContextRef { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for VsVip. Internally set by cloud connector. Field introduced in 17.2.9, 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_cloud_config_cksum")]
        public string? VsvipCloudConfigCksum { get; set; }
    }
}
