using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBServiceEnginePolicyType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Service Engine Group to which the policy is applied. It is a reference to an object of type ServiceEngineGroup. Field
        /// introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeGroupRef { get; set; }
        /// <summary>
        /// It is a reference to an object of type Tenant. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_ref")]
        public string? TenantRef { get; set; }
        /// <summary>
        /// Name of the Service Engine Policy. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// VRF context to which the policy is scoped. It is a reference to an object of type VrfContext. Field introduced in
        /// 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VrfRef { get; set; }
        /// <summary>
        /// Nat policy. It is a reference to an object of type NatPolicy. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "nat_policy_ref")]
        public string? NatPolicyRef { get; set; }
        /// <summary>
        /// UUID of the Service Engine Policy. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
