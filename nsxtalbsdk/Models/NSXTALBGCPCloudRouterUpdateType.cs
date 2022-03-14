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
    public class NSXTALBGCPCloudRouterUpdateType 
    {
        /// <summary>
        /// Action performed  Action can be either Route Added or Route Removed from Router. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Cloud UUID. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "cc_id")]
        public string? CcId { get; set; }
        /// <summary>
        /// Reason for the failure. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Virtual Service Floating IP. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "fip")]
        public NSXTALBIpAddrType Fip { get; set; }
        /// <summary>
        /// GCP Cloud Router URL. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "router_url")]
        public string? RouterUrl { get; set; }
        /// <summary>
        /// Virtual Service IP. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public NSXTALBIpAddrType Vip { get; set; }
        /// <summary>
        /// Virtual Service UUID. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
