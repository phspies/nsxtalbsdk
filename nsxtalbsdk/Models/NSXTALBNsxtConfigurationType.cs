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
    public class NSXTALBNsxtConfigurationType 
    {
        /// <summary>
        /// Automatically create DFW rules for VirtualService in NSX-T Manager. Field introduced in 20.1.1. Allowed in Basic(Allowed
        /// values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "automate_dfw_rules")]
        public bool? AutomateDfwRules { get; set; }
        /// <summary>
        /// Data network configuration for Avi Service Engines. Field introduced in 20.1.5. Allowed in Basic edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "data_network_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBDataNetworkConfigType DataNetworkConfig { get; set; }
        /// <summary>
        /// Domain where NSGroup objects belongs to. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "domain_id")]
        public string? DomainId { get; set; }
        /// <summary>
        /// Enforcement point is where the rules of a policy to apply. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enforcementpoint_id")]
        public string? EnforcementpointId { get; set; }
        /// <summary>
        /// Management network configuration for Avi Service Engines. Field introduced in 20.1.5. Allowed in Basic edition,
        /// Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "management_network_config", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBManagementNetworkConfigType ManagementNetworkConfig { get; set; }
        /// <summary>
        /// Management network segment to use for Avi Service Engines. Field deprecated in 20.1.5. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "management_segment")]
        public NSXTALBTier1LogicalRouterInfoType ManagementSegment { get; set; }
        /// <summary>
        /// Credentials to access NSX-T manager. It is a reference to an object of type CloudConnectorUser. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_credentials_ref", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NsxtCredentialsRef { get; set; }
        /// <summary>
        /// NSX-T manager hostname or IP address. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "nsxt_url", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NsxtUrl { get; set; }
        /// <summary>
        /// Site where transport zone belongs to. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
        /// <summary>
        /// Nsxt tier1 segment configuration for Avi Service Engine data path. Field deprecated in 20.1.5. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_segment_config")]
        public NSXTALBNsxtTier1SegmentConfigType Tier1SegmentConfig { get; set; }
        /// <summary>
        /// Network zone where nodes can talk via overlay. Virtual IPs and Service Engines will belong to this zone. Value should be
        /// path like /infra/sites/default/enforcement-points/default/transport-zones/xxx-xxx-xxxx. Field deprecated in 20.1.5.
        /// Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone")]
        public string? TransportZone { get; set; }
    }
}
