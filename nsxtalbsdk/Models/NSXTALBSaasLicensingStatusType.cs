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
    public class NSXTALBSaasLicensingStatusType 
    {
        public NSXTALBSaasLicensingStatusType()
        {
        }
        /// <summary>
        /// Portal connectivity status. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "connected")]
        public bool? Connected { get; set; }
        /// <summary>
        /// Status of saas licensing subscription. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Saas license expiry status. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "expired")]
        public bool? Expired { get; set; }
        /// <summary>
        /// Message. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Name. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Public key. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "public_key")]
        public string? PublicKey { get; set; }
        /// <summary>
        /// Service units reserved on controller. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "reserve_service_units")]
        public double? ReserveServiceUnits { get; set; }
    }
}
