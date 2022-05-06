using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBConfigSeGrpFlvUpdateType
    {
        /// <summary>
        /// New Flavor Name.
        /// </summary>
        [JsonProperty(PropertyName = "new_flv")]
        public string? NewFlv { get; set; }
        /// <summary>
        /// Old Flavor Name.
        /// </summary>
        [JsonProperty(PropertyName = "old_flv")]
        public string? OldFlv { get; set; }
        /// <summary>
        /// SE Group Name.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_name")]
        public string? SeGroupName { get; set; }
        /// <summary>
        /// SE Group UUID.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_uuid")]
        public string? SeGroupUuid { get; set; }
        /// <summary>
        /// Tenant Name.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_name")]
        public string? TenantName { get; set; }
        /// <summary>
        /// Tenant UUID.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
    }
}
