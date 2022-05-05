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
    public class NSXTALBControllerLimitsType 
    {
        /// <summary>
        /// BOT system limits. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "bot_limits")]
        public NSXTALBBOTLimitsType BotLimits { get; set; }
        /// <summary>
        /// Maximum number of certificates per virtualservice. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "certificates_per_virtualservice")]
        public int? CertificatesPerVirtualservice { get; set; }
        /// <summary>
        /// Controller system limits specific to cloud type for all controller sizes. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "controller_cloud_limits")]
        public IList<NSXTALBControllerCloudLimitsType> ControllerCloudLimits { get; set; }
        /// <summary>
        /// Controller system limits specific to controller sizing. Field introduced in 20.1.1. Maximum of 4 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "controller_sizing_limits")]
        public IList<NSXTALBControllerSizingLimitsType> ControllerSizingLimits { get; set; }
        /// <summary>
        /// Maximum number of default routes per vrfcontext. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "default_routes_per_vrfcontext")]
        public int? DefaultRoutesPerVrfcontext { get; set; }
        /// <summary>
        /// Maximum number of gateway monitors per vrfcontext. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_mon_per_vrf")]
        public int? GatewayMonPerVrf { get; set; }
        /// <summary>
        /// IP address limits. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ipaddress_limits")]
        public NSXTALBIPAddrLimitsType IpaddressLimits { get; set; }
        /// <summary>
        /// Maximum number of IP's per ipaddrgroup. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ips_per_ipgroup")]
        public int? IpsPerIpgroup { get; set; }
        /// <summary>
        /// System limits that apply to Layer 7 configuration objects. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "l7_limits")]
        public NSXTALBL7limitsType L7Limits { get; set; }
        /// <summary>
        /// Maximum number of poolgroups per virtualservice. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "poolgroups_per_virtualservice")]
        public int? PoolgroupsPerVirtualservice { get; set; }
        /// <summary>
        /// Maximum number of pools per poolgroup. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pools_per_poolgroup")]
        public int? PoolsPerPoolgroup { get; set; }
        /// <summary>
        /// Maximum number of pools per virtualservice. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "pools_per_virtualservice")]
        public int? PoolsPerVirtualservice { get; set; }
        /// <summary>
        /// Maximum number of routes per vrfcontext. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "routes_per_vrfcontext")]
        public int? RoutesPerVrfcontext { get; set; }
        /// <summary>
        /// Maximum number of rules per httppolicy. Field deprecated in 21.1.1. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rules_per_httppolicy")]
        public int? RulesPerHttppolicy { get; set; }
        /// <summary>
        /// Maximum number of nat rules in nat policy. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "rules_per_nat_policy")]
        public int? RulesPerNatPolicy { get; set; }
        /// <summary>
        /// Maximum number of rules per networksecuritypolicy. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "rules_per_networksecuritypolicy")]
        public int? RulesPerNetworksecuritypolicy { get; set; }
        /// <summary>
        /// Maximum number of servers per pool. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "servers_per_pool")]
        public int? ServersPerPool { get; set; }
        /// <summary>
        /// Maximum number of SNI children virtualservices per SNI parent virtualservice. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "sni_children_per_parent")]
        public int? SniChildrenPerParent { get; set; }
        /// <summary>
        /// Maximum number of strings per stringgroup. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "strings_per_stringgroup")]
        public int? StringsPerStringgroup { get; set; }
        /// <summary>
        /// Maximum number of serviceengine per virtualservice in bgp scaleout mode. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_bgp_scaleout")]
        public int? VsBgpScaleout { get; set; }
        /// <summary>
        /// Maximum number of serviceengine per virtualservice in layer 2 scaleout mode. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vs_l2_scaleout")]
        public int? VsL2Scaleout { get; set; }
        /// <summary>
        /// WAF system limits. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "waf_limits")]
        public NSXTALBWAFLimitsType WafLimits { get; set; }
    }
}
