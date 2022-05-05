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
    public class NSXTALBHTTPServerReselectType 
    {
        /// <summary>
        /// Enable HTTP request reselect when server responds with specific response codes. Allowed in Basic(Allowed values- false)
        /// edition, Essentials(Allowed values- false) edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
        /// <summary>
        /// Number of times to retry an HTTP request when server responds with configured status codes.
        /// </summary>
        [JsonProperty(PropertyName = "num_retries")]
        public int? NumRetries { get; set; }
        /// <summary>
        /// Allow retry of non-idempotent HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "retry_nonidempotent")]
        public bool? RetryNonidempotent { get; set; }
        /// <summary>
        /// Timeout per retry attempt, for a given request. Value of 0 indicates default timeout. Allowed values are 0-3600000.
        /// Field introduced in 18.1.5,18.2.1. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "retry_timeout")]
        public int? RetryTimeout { get; set; }
        /// <summary>
        /// Server response codes which will trigger an HTTP request retry.
        /// </summary>
        [JsonProperty(PropertyName = "svr_resp_code")]
        public NSXTALBHTTPReselectRespCodeType SvrRespCode { get; set; }
    }
}
