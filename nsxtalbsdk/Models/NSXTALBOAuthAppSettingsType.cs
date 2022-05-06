using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOAuthAppSettingsType
    {
        /// <summary>
        /// Application specific identifier. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClientId { get; set; }
        /// <summary>
        /// Application specific identifier secret. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClientSecret { get; set; }
        /// <summary>
        /// OpenID Connect specific configuration. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_config")]
        public NSXTALBOIDCConfigType OidcConfig { get; set; }
        /// <summary>
        /// Scope specified to give limited access to the app. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public IList<string> Scopes { get; set; }
    }
}
