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
    public class NSXTALBOAuthVSConfigType 
    {
        /// <summary>
        /// HTTP cookie name for authorized session. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_name")]
        public string? CookieName { get; set; }
        /// <summary>
        /// HTTP cookie timeout for authorized session. Allowed values are 1-1440. Field introduced in 21.1.3. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "cookie_timeout")]
        public int? CookieTimeout { get; set; }
        /// <summary>
        /// Key to generate the cookie. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public IList<NSXTALBHttpCookiePersistenceKeyType> Key { get; set; }
        /// <summary>
        /// Application and IDP settings for OAuth/OIDC. Field introduced in 21.1.3. Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "oauth_settings")]
        public IList<NSXTALBOAuthSettingsType> OauthSettings { get; set; }
        /// <summary>
        /// Redirect URI specified in the request to Authorization Server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_uri")]
        public string? RedirectUri { get; set; }
    }
}
