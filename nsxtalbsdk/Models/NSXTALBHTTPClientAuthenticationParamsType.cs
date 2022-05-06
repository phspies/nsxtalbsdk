using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPClientAuthenticationParamsType
    {
        /// <summary>
        /// Auth Profile to use for validating users. It is a reference to an object of type AuthProfile.
        /// </summary>
        [JsonProperty(PropertyName = "auth_profile_ref")]
        public string? AuthProfileRef { get; set; }
        /// <summary>
        /// Basic authentication realm to present to a user along with the prompt for credentials.
        /// </summary>
        [JsonProperty(PropertyName = "realm")]
        public string? Realm { get; set; }
        /// <summary>
        /// Rrequest URI path when the authentication applies.
        /// </summary>
        [JsonProperty(PropertyName = "request_uri_path")]
        public NSXTALBStringMatchType RequestUriPath { get; set; }
        /// <summary>
        /// type of client authentication. Enum options - HTTP_BASIC_AUTH.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
