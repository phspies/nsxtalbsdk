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
    public class NSXTALBCustomerPortalInfoType 
    {
        /// <summary>
        /// url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Time interval in minutes. Allowed values are 5-60. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "polling_interval")]
        public int? PollingInterval { get; set; }
        /// <summary>
        /// Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// The FQDN or IP address of the customer portal. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "portal_url", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string PortalUrl { get; set; }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
    }
}
