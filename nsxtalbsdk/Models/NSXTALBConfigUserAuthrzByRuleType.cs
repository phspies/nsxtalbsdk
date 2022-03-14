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
    public class NSXTALBConfigUserAuthrzByRuleType 
    {
        public NSXTALBConfigUserAuthrzByRuleType()
        {
        }
        /// <summary>
        /// Comma separated list of policies assigned to the user. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "policies")]
        public string? Policies { get; set; }
        /// <summary>
        /// assigned roles.
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public string? Roles { get; set; }
        /// <summary>
        /// matching rule string.
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string? Rule { get; set; }
        /// <summary>
        /// assigned tenants.
        /// </summary>
        [JsonProperty(PropertyName = "tenants")]
        public string? Tenants { get; set; }
        /// <summary>
        /// Request user.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// assigned user account profile name. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "userprofile")]
        public string? Userprofile { get; set; }
    }
}
