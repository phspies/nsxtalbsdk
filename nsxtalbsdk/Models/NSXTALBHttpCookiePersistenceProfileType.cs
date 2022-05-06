using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHttpCookiePersistenceProfileType
    {
        /// <summary>
        /// If no persistence cookie was received from the client, always send it.
        /// </summary>
        [JsonProperty(PropertyName = "always_send_cookie")]
        public bool? AlwaysSendCookie { get; set; }
        /// <summary>
        /// HTTP cookie name for cookie persistence.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        public string? CookieName { get; set; }
        /// <summary>
        /// Key name to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key")]
        public string? EncryptionKey { get; set; }
        /// <summary>
        /// Sets the HttpOnly attribute in the cookie. Setting this helps to prevent the client side scripts from accessing this
        /// cookie, if supported by browser. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "http_only")]
        public bool? HttpOnly { get; set; }
        /// <summary>
        /// When True, the cookie used is a persistent cookie, i.e. the cookie shouldn't be used at the end of the timeout. By
        /// default, it is set to false, making the cookie a session cookie, which allows clients to use it even after the timeout,
        /// if the session is still open. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "is_persistent_cookie")]
        public bool? IsPersistentCookie { get; set; }
        /// <summary>
        /// Placeholder for description of property key of obj type HttpCookiePersistenceProfile field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// The maximum lifetime of any session cookie. No value or 'zero' indicates no timeout. Allowed values are 1-14400. Special
        /// values are 0- No Timeout. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }
    }
}
