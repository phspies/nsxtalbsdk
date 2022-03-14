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
    public class NSXTALBTenantConfigurationType 
    {
        /// <summary>
        /// Controls the ownership of ServiceEngines. Service Engines can either be exclusively owned by each tenant or owned by the
        /// administrator and shared by all tenants. When ServiceEngines are owned by the administrator, each tenant can have either
        /// read access or no access to their Service Engines.
        /// </summary>
        [JsonProperty(PropertyName = "se_in_provider_context")]
        public bool? SeInProviderContext { get; set; }
        /// <summary>
        /// Placeholder for description of property tenant_access_to_provider_se of obj type TenantConfiguration field type str 
        /// type boolean
        /// </summary>
        [JsonProperty(PropertyName = "tenant_access_to_provider_se")]
        public bool? TenantAccessToProviderSe { get; set; }
        /// <summary>
        /// When 'Per Tenant IP Domain' is selected, each tenant gets its own routing domain that is not shared with any other
        /// tenant. When 'Share IP Domain across all tenants' is selected, all tenants share the same routing domain.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_vrf")]
        public bool? TenantVrf { get; set; }
    }
}
