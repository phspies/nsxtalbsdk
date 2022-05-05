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
    public class NSXTALBOauthSubRequestLogType 
    {
        /// <summary>
        /// Error code. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public string? ErrorCode { get; set; }
        /// <summary>
        /// Error description. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "error_description")]
        public string? ErrorDescription { get; set; }
        /// <summary>
        /// Subrequest info related to the Oauth flow. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "sub_request_log")]
        public NSXTALBSubRequestLogType SubRequestLog { get; set; }
    }
}
