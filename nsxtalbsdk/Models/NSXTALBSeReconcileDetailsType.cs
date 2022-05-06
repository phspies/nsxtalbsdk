using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSeReconcileDetailsType
    {
        /// <summary>
        /// Placeholder for description of property new_service_cores of obj type SeReconcileDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "new_service_cores")]
        public double? NewServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property old_service_cores of obj type SeReconcileDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "old_service_cores")]
        public double? OldServiceCores { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid")]
        public string? SeUuid { get; set; }
        /// <summary>
        /// Unique object identifier of tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// tier of SeReconcileDetails.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string? Tier { get; set; }
    }
}
