using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSamlSettingsType
    {
        /// <summary>
        /// Configure remote Identity provider settings. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "idp")]
        public NSXTALBSamlIdentityProviderSettingsType Idp { get; set; }
        /// <summary>
        /// Configure service provider settings for the Controller. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "sp")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBSamlServiceProviderSettingsType Sp { get; set; }
    }
}
