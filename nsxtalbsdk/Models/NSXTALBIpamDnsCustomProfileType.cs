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
    public class NSXTALBIpamDnsCustomProfileType 
    {
        /// <summary>
        /// It is a reference to an object of type CustomIpamDnsProfile. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "custom_ipam_dns_profile_ref")]
        public string? CustomIpamDnsProfileRef { get; set; }
        /// <summary>
        /// Custom parameters that will passed to the IPAM/DNS provider including but not limited to provider credentials and API
        /// version. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_params")]
        public IList<NSXTALBCustomParamsType> DynamicParams { get; set; }
        /// <summary>
        /// Networks or Subnets to use for Custom IPAM IP allocation. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_alloc_subnets")]
        public IList<NSXTALBCustomIpamSubnetType> UsableAllocSubnets { get; set; }
        /// <summary>
        /// Usable domains. Field introduced in 17.2.2.
        /// </summary>
        [JsonProperty(PropertyName = "usable_domains")]
        public IList<string> UsableDomains { get; set; }
        /// <summary>
        /// Usable subnets. Field deprecated in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usable_subnets")]
        public IList<NSXTALBIpAddrPrefixType> UsableSubnets { get; set; }
    }
}
