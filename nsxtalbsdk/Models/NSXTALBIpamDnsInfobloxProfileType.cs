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
    public class NSXTALBIpamDnsInfobloxProfileType 
    {
        public NSXTALBIpamDnsInfobloxProfileType()
        {
        }
        /// <summary>
        /// DNS view.
        /// </summary>
        [JsonProperty(PropertyName = "dns_view")]
        public string? DnsView { get; set; }
        /// <summary>
        /// Custom parameters that will passed to the Infoblox provider as extensible attributes. Field introduced in 18.2.7,
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "extensible_attributes")]
        public IList<NSXTALBCustomParamsType> ExtensibleAttributes { get; set; }
        /// <summary>
        /// Address of Infoblox appliance.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType IpAddress { get; set; }
        /// <summary>
        /// Network view.
        /// </summary>
        [JsonProperty(PropertyName = "network_view")]
        public string? NetworkView { get; set; }
        /// <summary>
        /// Password for API access for Infoblox appliance.
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        /// <summary>
        /// Subnets to use for Infoblox IP allocation. Field introduced in 18.2.8, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_alloc_subnets")]
        public IList<NSXTALBInfobloxSubnetType> UsableAllocSubnets { get; set; }
        /// <summary>
        /// Usable domains to pick from Infoblox.
        /// </summary>
        [JsonProperty(PropertyName = "usable_domains")]
        public IList<string> UsableDomains { get; set; }
        /// <summary>
        /// This field is deprecated, use usable_alloc_subnets instead. Field deprecated in 18.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "usable_subnets")]
        public IList<NSXTALBIpAddrPrefixType> UsableSubnets { get; set; }
        /// <summary>
        /// Username for API access for Infoblox appliance.
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Username { get; set; }
        /// <summary>
        /// WAPI version.
        /// </summary>
        [JsonProperty(PropertyName = "wapi_version")]
        public string? WapiVersion { get; set; }
    }
}
