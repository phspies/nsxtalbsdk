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
    public class NSXTALBAuthorizationActionType 
    {
        /// <summary>
        /// HTTP status code to use for local response when an policy rule is matched. Enum options - HTTP_RESPONSE_STATUS_CODE_401,
        /// HTTP_RESPONSE_STATUS_CODE_403. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public string? StatusCode { get; set; }
        /// <summary>
        /// Defines the action taken when an authorization policy rule is matched. By default, access is allowed to the requested
        /// resource. Enum options - ALLOW_ACCESS, CLOSE_CONNECTION, HTTP_LOCAL_RESPONSE. Field introduced in 18.2.5.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
