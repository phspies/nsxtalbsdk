using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTPRewriteLocHdrActionType
    {
        /// <summary>
        /// Host config.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public NSXTALBURIParamType Host { get; set; }
        /// <summary>
        /// Keep or drop the query from the server side redirect URI.
        /// </summary>
        [JsonProperty(PropertyName = "keep_query")]
        public bool? KeepQuery { get; set; }
        /// <summary>
        /// Path config.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public NSXTALBURIParamType Path { get; set; }
        /// <summary>
        /// Port to use in the redirected URI. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }
        /// <summary>
        /// HTTP protocol type. Enum options - HTTP, HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
    }
}
