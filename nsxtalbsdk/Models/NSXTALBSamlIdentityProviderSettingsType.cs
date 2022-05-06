using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSamlIdentityProviderSettingsType
    {
        /// <summary>
        /// SAML IDP metadata. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string? Metadata { get; set; }
    }
}
