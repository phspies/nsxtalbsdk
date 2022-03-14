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
    public class NSXTALBOIDCConfigType 
    {
        public NSXTALBOIDCConfigType()
        {
        }
        /// <summary>
        /// Adds openid as one of the scopes enabling OpenID Connect flow. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_enable")]
        public bool? OidcEnable { get; set; }
        /// <summary>
        /// Fetch profile information by enabling profile scope. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public bool? Profile { get; set; }
        /// <summary>
        /// Fetch profile information from Userinfo Endpoint. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "userinfo")]
        public bool? Userinfo { get; set; }
    }
}
