using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPRedirectActionType
    {
        /// <summary>
        /// Add a query string to the redirect URI. If keep_query is set, concatenates the add_string to the query of the incoming
        /// request. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "add_string")]
        public string? AddString { get; set; }
        /// <summary>
        /// Host config.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public NSXTALBURIParamType Host { get; set; }
        /// <summary>
        /// Keep or drop the query of the incoming request URI in the redirected URI.
        /// </summary>
        [JsonProperty(PropertyName = "keep_query")]
        public bool? KeepQuery { get; set; }
        /// <summary>
        /// Path config.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBURIParamType Path { get; set; }
        /// <summary>
        /// Port to which redirect the request. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// Protocol type. Enum options - HTTP, HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
        /// <summary>
        /// HTTP redirect status code. Enum options - HTTP_REDIRECT_STATUS_CODE_301, HTTP_REDIRECT_STATUS_CODE_302,
        /// HTTP_REDIRECT_STATUS_CODE_307.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public string? StatusCode { get; set; }
    }
}
