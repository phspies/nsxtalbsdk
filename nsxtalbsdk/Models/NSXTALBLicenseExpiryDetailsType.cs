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
    public class NSXTALBLicenseExpiryDetailsType 
    {
        public NSXTALBLicenseExpiryDetailsType()
        {
        }
        /// <summary>
        /// Number of backend_servers.
        /// </summary>
        [JsonProperty(PropertyName = "backend_servers")]
        public int? BackendServers { get; set; }
        /// <summary>
        /// Number of burst_cores.
        /// </summary>
        [JsonProperty(PropertyName = "burst_cores")]
        public int? BurstCores { get; set; }
        /// <summary>
        /// Number of cores.
        /// </summary>
        [JsonProperty(PropertyName = "cores")]
        public int? Cores { get; set; }
        /// <summary>
        /// Placeholder for description of property cpu_cores of obj type LicenseExpiryDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "cpu_cores")]
        public double? CpuCores { get; set; }
        /// <summary>
        /// expiry_at of LicenseExpiryDetails.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_at")]
        public string? ExpiryAt { get; set; }
        /// <summary>
        /// license_id of LicenseExpiryDetails.
        /// </summary>
        [JsonProperty(PropertyName = "license_id")]
        public string? LicenseId { get; set; }
        /// <summary>
        /// license_tier of LicenseExpiryDetails.
        /// </summary>
        [JsonProperty(PropertyName = "license_tier")]
        public IList<string> LicenseTier { get; set; }
        /// <summary>
        /// license_type of LicenseExpiryDetails.
        /// </summary>
        [JsonProperty(PropertyName = "license_type")]
        public string? LicenseType { get; set; }
        /// <summary>
        /// Number of max_apps.
        /// </summary>
        [JsonProperty(PropertyName = "max_apps")]
        public int? MaxApps { get; set; }
        /// <summary>
        /// Number of max_ses.
        /// </summary>
        [JsonProperty(PropertyName = "max_ses")]
        public int? MaxSes { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Placeholder for description of property service_cores of obj type LicenseExpiryDetails field type str  type number
        /// </summary>
        [JsonProperty(PropertyName = "service_cores")]
        public double? ServiceCores { get; set; }
        /// <summary>
        /// Number of sockets.
        /// </summary>
        [JsonProperty(PropertyName = "sockets")]
        public int? Sockets { get; set; }
        /// <summary>
        /// Number of throughput.
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public int? Throughput { get; set; }
    }
}
