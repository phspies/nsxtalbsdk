using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerLicenseReconcileDetailsType
    {
        /// <summary>
        /// Placeholder for description of property new_available_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "new_available_service_cores")]
        public double? NewAvailableServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property new_consumed_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "new_consumed_service_cores")]
        public double? NewConsumedServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property new_escrow_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "new_escrow_service_cores")]
        public double? NewEscrowServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property new_remaining_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "new_remaining_service_cores")]
        public double? NewRemainingServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property old_available_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "old_available_service_cores")]
        public double? OldAvailableServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property old_consumed_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "old_consumed_service_cores")]
        public double? OldConsumedServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property old_escrow_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "old_escrow_service_cores")]
        public double? OldEscrowServiceCores { get; set; }
        /// <summary>
        /// Placeholder for description of property old_remaining_service_cores of obj type ControllerLicenseReconcileDetails field
        /// type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "old_remaining_service_cores")]
        public double? OldRemainingServiceCores { get; set; }
        /// <summary>
        /// Unique object identifier of tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// tier of ControllerLicenseReconcileDetails.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string? Tier { get; set; }
    }
}
