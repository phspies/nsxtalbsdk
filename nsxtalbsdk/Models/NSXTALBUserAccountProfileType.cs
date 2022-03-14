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
    public class NSXTALBUserAccountProfileType 
    {
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Lock timeout period (in minutes). Default is 30 minutes. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "account_lock_timeout")]
        public int? AccountLockTimeout { get; set; }
        /// <summary>
        /// Protobuf versioning for config pbs. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "configpb_attributes")]
        public NSXTALBConfigPbAttributesType ConfigpbAttributes { get; set; }
        /// <summary>
        /// The time period after which credentials expire. Default is 180 days. Unit is DAYS.
        /// </summary>
        [JsonProperty(PropertyName = "credentials_timeout_threshold")]
        public int? CredentialsTimeoutThreshold { get; set; }
        /// <summary>
        /// The configurable time window beyond which we need to pop all the login failure timestamps from the
        /// login_failure_timestamps. Special values are 0 - Do not reset login_failure_counts on the basis of time.. Field
        /// introduced in 22.1.1. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "login_failure_count_expiry_window")]
        public int? LoginFailureCountExpiryWindow { get; set; }
        /// <summary>
        /// Maximum number of concurrent sessions allowed. There are unlimited sessions by default.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_sessions")]
        public int? MaxConcurrentSessions { get; set; }
        /// <summary>
        /// Number of login attempts before lockout. Default is 3 attempts. Allowed values are 3-20. Special values are 0- Unlimited
        /// login attempts allowed..
        /// </summary>
        [JsonProperty(PropertyName = "max_login_failure_count")]
        public int? MaxLoginFailureCount { get; set; }
        /// <summary>
        /// Maximum number of passwords to be maintained in the password history. Default is 4 passwords.
        /// </summary>
        [JsonProperty(PropertyName = "max_password_history_count")]
        public int? MaxPasswordHistoryCount { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
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
    }
}
