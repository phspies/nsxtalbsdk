using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBErrorPageType
    {
        /// <summary>
        /// Enable or disable the error page. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Custom error page body used to sent to the client. It is a reference to an object of type ErrorPageBody. Field
        /// introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "error_page_body_ref")]
        public string? ErrorPageBodyRef { get; set; }
        /// <summary>
        /// Redirect sent to client when match. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "error_redirect")]
        public string? ErrorRedirect { get; set; }
        /// <summary>
        /// Index of the error page. Field introduced in 17.2.4.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; set; }
        /// <summary>
        /// Add match criteria for http status codes to the error page. Field introduced in 17.2.4. Allowed in Basic edition,
        /// Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBHTTPStatusMatchType Match { get; set; }
    }
}
