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
    public class NSXTALBLicenseTierUsageType 
    {
        /// <summary>
        /// Specifies the license tier. Enum options - ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS,
        /// ENTERPRISE_WITH_CLOUD_SERVICES. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string? Tier { get; set; }
        /// <summary>
        /// Usage stats of license tier. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public NSXTALBLicenseUsageType Usage { get; set; }
    }
}
