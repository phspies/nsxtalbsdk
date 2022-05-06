using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBControllerPortalAuthType
    {
        /// <summary>
        /// Access Token to authenticate Customer Portal REST calls. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string? AccessToken { get; set; }
        /// <summary>
        /// Salesforce instance URL. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "instance_url")]
        public string? InstanceUrl { get; set; }
        /// <summary>
        /// Signed JWT to refresh the access token. Field introduced in 18.2.6.
        /// </summary>
        [JsonProperty(PropertyName = "jwt_token")]
        public string? JwtToken { get; set; }
    }
}
