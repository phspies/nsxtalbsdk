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
    public class NSXTALBSingleLicenseType 
    {
        /// <summary>
        /// Total number of Service Engine burst cores for core based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "burst_cores")]
        public int? BurstCores { get; set; }
        /// <summary>
        /// Number of Service Engine cores in non-container clouds.
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public double? Cores { get; set; }
        /// <summary>
        /// Total number of cpu cores. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_cores")]
        public double? CpuCores { get; set; }
        /// <summary>
        /// created_on of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "created_on")]
        public string? CreatedOn { get; set; }
        /// <summary>
        /// customer_name of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "customer_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string CustomerName { get; set; }
        /// <summary>
        /// enforced_params of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "enforced_params")]
        public IList<string> EnforcedParams { get; set; }
        /// <summary>
        /// Flag to track license expiry. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "expired")]
        public bool? Expired { get; set; }
        /// <summary>
        /// last_update of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "last_update")]
        public string? LastUpdate { get; set; }
        /// <summary>
        /// license_id of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "license_id")]
        public string? LicenseId { get; set; }
        /// <summary>
        /// license_name of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "license_name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string LicenseName { get; set; }
        /// <summary>
        /// license_string of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "license_string")]
        public string? LicenseString { get; set; }
        /// <summary>
        /// license_tier of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "license_tier")]
        public IList<string> LicenseTier { get; set; }
        /// <summary>
        /// license_type of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "license_type")]
        public string? LicenseType { get; set; }
        /// <summary>
        /// Number of Service Engines hosts in container clouds.
        /// </summary>
        [JsonProperty(PropertyName = "max_ses")]
        public int? MaxSes { get; set; }
        /// <summary>
        /// Service Engine bandwidth limits for bandwidth based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_bandwidth_limits")]
        public IList<NSXTALBSEBandwidthLimitType> SeBandwidthLimits { get; set; }
        /// <summary>
        /// Serial key (Hyphen separated 25 char wide alphanumeric key Ex  AA123-23BAS-383AS-383UD-FHSFG). Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "serial_key")]
        public string? SerialKey { get; set; }
        /// <summary>
        /// Total number of service cores equivalent to all the resoures available in the single license. Field introduced in
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_cores")]
        public double? ServiceCores { get; set; }
        /// <summary>
        /// Number of physical cpu sockets across Service Engines in no access and linux server clouds.
        /// </summary>
        [JsonProperty(PropertyName = "sockets")]
        public int? Sockets { get; set; }
        /// <summary>
        /// start_on of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "start_on")]
        public string? StartOn { get; set; }
        /// <summary>
        /// Specifies the licensed tier. Enum options - ENTERPRISE_16, ENTERPRISE, ENTERPRISE_18, BASIC, ESSENTIALS. Field
        /// introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "tier_type")]
        public string? TierType { get; set; }
        /// <summary>
        /// valid_until of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "valid_until", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ValidUntil { get; set; }
        /// <summary>
        /// version of SingleLicense.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
    }
}
