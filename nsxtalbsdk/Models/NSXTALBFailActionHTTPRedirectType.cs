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
    public class NSXTALBFailActionHTTPRedirectType 
    {
        /// <summary>
        /// The host to which the redirect request is sent.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Host { get; set; }
        /// <summary>
        /// Path configuration for the redirect request. If not set the path from the original request's URI is preserved in the
        /// redirect on pool failure.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// Enum options - HTTP, HTTPS. Allowed in Basic(Allowed values- HTTP) edition, Enterprise edition. Special default for
        /// Basic edition is HTTP, Enterprise is HTTPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string? Protocol { get; set; }
        /// <summary>
        /// Query configuration for the redirect request URI. If not set, the query from the original request's URI is preserved in
        /// the redirect on pool failure.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string? Query { get; set; }
        /// <summary>
        /// Enum options - HTTP_REDIRECT_STATUS_CODE_301, HTTP_REDIRECT_STATUS_CODE_302, HTTP_REDIRECT_STATUS_CODE_307. Allowed in
        /// Basic(Allowed values- HTTP_REDIRECT_STATUS_CODE_302) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public string? StatusCode { get; set; }
    }
}
