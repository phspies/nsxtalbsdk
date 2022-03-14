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
    public class NSXTALBConfigUserPasswordChangeRequestType 
    {
        /// <summary>
        /// client ip.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public string? ClientIp { get; set; }
        /// <summary>
        /// Password link is sent or rejected.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// Matched username of email address.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// Email address of user.
        /// </summary>
        [JsonProperty(PropertyName = "user_email")]
        public string? UserEmail { get; set; }
    }
}
