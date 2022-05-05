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
    public class NSXTALBLicenseDetailsType 
    {
        /// <summary>
        /// Number of backend_servers.
        /// </summary>
        [JsonProperty(PropertyName = "backend_servers")]
        public int? BackendServers { get; set; }
        /// <summary>
        /// expiry_at of LicenseDetails.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_at")]
        public string? ExpiryAt { get; set; }
        /// <summary>
        /// license_id of LicenseDetails.
        /// </summary>
        [JsonProperty(PropertyName = "license_id")]
        public string? LicenseId { get; set; }
        /// <summary>
        /// license_type of LicenseDetails.
        /// </summary>
        [JsonProperty(PropertyName = "license_type")]
        public string? LicenseType { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
