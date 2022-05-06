using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBLicenseTransactionDetailsType
    {
        /// <summary>
        /// cookie of LicenseTransactionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        public string? Cookie { get; set; }
        /// <summary>
        /// User defined description for the object.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// id of LicenseTransactionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Placeholder for description of property licensed_service_cores of obj type LicenseTransactionDetails field type str 
        /// type number
        /// </summary>
        [JsonProperty(PropertyName = "licensed_service_cores")]
        public double? LicensedServiceCores { get; set; }
        /// <summary>
        /// operation of LicenseTransactionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string? Operation { get; set; }
        /// <summary>
        /// Placeholder for description of property overdraft of obj type LicenseTransactionDetails field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "overdraft")]
        public bool? Overdraft { get; set; }
        /// <summary>
        /// Placeholder for description of property service_cores of obj type LicenseTransactionDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "service_cores")]
        public double? ServiceCores { get; set; }
        /// <summary>
        /// Unique object identifier of tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// tier of LicenseTransactionDetails.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string? Tier { get; set; }
    }
}
