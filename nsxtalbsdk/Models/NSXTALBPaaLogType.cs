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
    public class NSXTALBPaaLogType 
    {
        public NSXTALBPaaLogType()
        {
        }
        /// <summary>
        /// PingAccess Agent cache was used for authentication. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "cache_hit")]
        public bool? CacheHit { get; set; }
        /// <summary>
        /// The PingAccess server required the client request body for authentication. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "client_request_body_sent")]
        public bool? ClientRequestBodySent { get; set; }
        /// <summary>
        /// Logs for each request sent to PA server to completeauthentication for the initial request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "request_logs")]
        public IList<NSXTALBPaaRequestLogType> RequestLogs { get; set; }
    }
}
