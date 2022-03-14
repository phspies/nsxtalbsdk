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
    public class NSXTALBUserActivityType 
    {
        public NSXTALBUserActivityType()
        {
        }
        /// <summary>
        /// UNIX time since epoch in microseconds. Units(MICROSECONDS).
        /// </summary>
        [JsonProperty(PropertyName = "_last_modified")]
        public string? LastModified { get; set; }
        /// <summary>
        /// Number of concurrent user sessions open.
        /// </summary>
        [JsonProperty(PropertyName = "concurrent_sessions")]
        public int? ConcurrentSessions { get; set; }
        /// <summary>
        /// Number of failed login attempts before a successful login.
        /// </summary>
        [JsonProperty(PropertyName = "failed_login_attempts")]
        public int? FailedLoginAttempts { get; set; }
        /// <summary>
        /// IP of the machine the user was last logged in from.
        /// </summary>
        [JsonProperty(PropertyName = "last_login_ip")]
        public string? LastLoginIp { get; set; }
        /// <summary>
        /// Timestamp of last login.
        /// </summary>
        [JsonProperty(PropertyName = "last_login_timestamp")]
        public string? LastLoginTimestamp { get; set; }
        /// <summary>
        /// Timestamp of last password update.
        /// </summary>
        [JsonProperty(PropertyName = "last_password_update")]
        public string? LastPasswordUpdate { get; set; }
        /// <summary>
        /// Indicates whether the user is logged in or not.
        /// </summary>
        [JsonProperty(PropertyName = "logged_in")]
        public bool? LoggedIn { get; set; }
        /// <summary>
        /// Its a queue that store the timestamps for past login_failures. Field introduced in 22.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "login_failure_timestamps")]
        public IList<string> LoginFailureTimestamps { get; set; }
        /// <summary>
        /// Name of the user this object refers to.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Stores the previous n passwords  where n is ControllerProperties.max_password_history_count. .
        /// </summary>
        [JsonProperty(PropertyName = "previous_password")]
        public IList<string> PreviousPassword { get; set; }
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
