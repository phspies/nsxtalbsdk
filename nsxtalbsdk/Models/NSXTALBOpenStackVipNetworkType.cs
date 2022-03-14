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
    public class NSXTALBOpenStackVipNetworkType 
    {
        /// <summary>
        /// Neutron network UUID. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "os_network_uuid")]
        public string? OsNetworkUuid { get; set; }
        /// <summary>
        /// UUIDs of OpenStack tenants that should be allowed to use the specified Neutron network for VIPs. Use '*' to make this
        /// network available to all tenants. Field introduced in 18.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "os_tenant_uuids")]
        public IList<string> OsTenantUuids { get; set; }
    }
}
