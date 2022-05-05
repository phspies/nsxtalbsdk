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
    public class NSXTALBLicenseInfoType 
    {
        /// <summary>
        /// Last updated time. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "last_updated")]
        [System.ComponentModel.DataAnnotations.Required]
        public long LastUpdated { get; set; }
        /// <summary>
        /// Quantity of service cores. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_cores")]
        [System.ComponentModel.DataAnnotations.Required]
        public double ServiceCores { get; set; }
        /// <summary>
        /// Specifies the license tier. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// Specifies the license tier. Enum options - ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS,
        /// ENTERPRISE_WITH_CLOUD_SERVICES. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Tier { get; set; }
        /// <summary>
        /// Identifier(license_id, se_uuid, cookie). Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
    }
}
