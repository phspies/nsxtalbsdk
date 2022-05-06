using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerLicenseType
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// List of active burst core license in use. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "active_burst_resources")]
        public IList<NSXTALBBurstResourceType> ActiveBurstResources { get; set; }
        /// <summary>
        /// Total number of Service Engine cores for burst core based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "burst_cores")]
        public int? BurstCores { get; set; }
        /// <summary>
        /// Number of Service Engine cores in non-container clouds.
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public int? Cores { get; set; }
        /// <summary>
        /// customer_name of ControllerLicense.
        /// </summary>
        [JsonProperty(PropertyName = "customer_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string CustomerName { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "disable_enforcement")]
        public bool? DisableEnforcement { get; set; }
        /// <summary>
        /// List of used or expired burst core licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "expired_burst_resources")]
        public IList<NSXTALBBurstResourceType> ExpiredBurstResources { get; set; }
        /// <summary>
        /// Flag used to track initialization. Field introduced in 20.1.2.
        /// </summary>
        [JsonProperty(PropertyName = "initialized")]
        public bool? Initialized { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "license_id")]
        public string? LicenseId { get; set; }
        /// <summary>
        /// license_tier of ControllerLicense.
        /// </summary>
        [JsonProperty(PropertyName = "license_tier")]
        public IList<string> LicenseTier { get; set; }
        /// <summary>
        /// Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "license_tiers")]
        public IList<NSXTALBCumulativeLicenseType> LicenseTiers { get; set; }
        /// <summary>
        /// Placeholder for description of property licenses of obj type ControllerLicense field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public IList<NSXTALBSingleLicenseType> Licenses { get; set; }
        /// <summary>
        /// Number of Service Engines hosts in container clouds.
        /// </summary>
        [JsonProperty(PropertyName = "max_ses")]
        public int? MaxSes { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Service Engine bandwidth limits for bandwidth based licenses. Field introduced in 17.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "se_bandwidth_limits")]
        public IList<NSXTALBSEBandwidthLimitType> SeBandwidthLimits { get; set; }
        /// <summary>
        /// Number of vmware service cores after aggregating all other license types. Field introduced in 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "service_cores")]
        public double? ServiceCores { get; set; }
        /// <summary>
        /// Number of physical cpu sockets across Service Engines in no access and linux server clouds.
        /// </summary>
        [JsonProperty(PropertyName = "sockets")]
        public int? Sockets { get; set; }
        /// <summary>
        /// start_on of ControllerLicense.
        /// </summary>
        [JsonProperty(PropertyName = "start_on")]
        public string? StartOn { get; set; }
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// valid_until of ControllerLicense.
        /// </summary>
        [JsonProperty(PropertyName = "valid_until")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ValidUntil { get; set; }
    }
}
