using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOAuthSettingsType
    {
        /// <summary>
        /// Application-specific OAuth config. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "app_settings")]
        public NSXTALBOAuthAppSettingsType AppSettings { get; set; }
        /// <summary>
        /// Auth Profile to use for validating users. It is a reference to an object of type AuthProfile. Field introduced in
        /// 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_ref")]
        [System.ComponentModel.DataAnnotations.Required]
        public string AuthProfileRef { get; set; }
        /// <summary>
        /// Resource Server OAuth config. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "resource_server")]
        public NSXTALBOAuthResourceServerType ResourceServer { get; set; }
    }
}
