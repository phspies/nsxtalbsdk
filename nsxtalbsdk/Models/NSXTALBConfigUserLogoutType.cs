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
    public class NSXTALBConfigUserLogoutType 
    {
        public NSXTALBConfigUserLogoutType()
        {
        }
        /// <summary>
        /// client ip.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public string? ClientIp { get; set; }
        /// <summary>
        /// error message if logging out failed.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Local user. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public bool? Local { get; set; }
        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Request user.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
