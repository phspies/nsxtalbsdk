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
    public class NSXTALBSubRequestLogType 
    {
        public NSXTALBSubRequestLogType()
        {
        }
        /// <summary>
        /// Response headers received from the server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "headers_received_from_server")]
        public string? HeadersReceivedFromServer { get; set; }
        /// <summary>
        /// Request headers sent to the server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "headers_sent_to_server")]
        public string? HeadersSentToServer { get; set; }
        /// <summary>
        /// The HTTP response code received from the server. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "http_response_code")]
        public int? HttpResponseCode { get; set; }
        /// <summary>
        /// The HTTP version of the sub-request. Enum options - ZERO_NINE, ONE_ZERO, ONE_ONE, TWO_ZERO. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "http_version")]
        public string? HttpVersion { get; set; }
        /// <summary>
        /// The HTTP method of the sub-request. Enum options - HTTP_METHOD_GET, HTTP_METHOD_HEAD, HTTP_METHOD_PUT,
        /// HTTP_METHOD_DELETE, HTTP_METHOD_POST, HTTP_METHOD_OPTIONS, HTTP_METHOD_TRACE, HTTP_METHOD_CONNECT, HTTP_METHOD_PATCH,
        /// HTTP_METHOD_PROPFIND, HTTP_METHOD_PROPPATCH, HTTP_METHOD_MKCOL, HTTP_METHOD_COPY, HTTP_METHOD_MOVE, HTTP_METHOD_LOCK,
        /// HTTP_METHOD_UNLOCK. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string? Method { get; set; }
        /// <summary>
        /// The name of the pool that was used for the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// The uuid of the pool that was used for the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Length of the request sent in bytes. Field introduced in 21.1.3. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "request_length")]
        public long? RequestLength { get; set; }
        /// <summary>
        /// Length of the response received in bytes. Field introduced in 21.1.3. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "response_length")]
        public long? ResponseLength { get; set; }
        /// <summary>
        /// The IP of the server that was used for the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public int? ServerIp { get; set; }
        /// <summary>
        /// The name of the server that was used for the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        public string? ServerName { get; set; }
        /// <summary>
        /// The port of the server that was used for the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_port")]
        public int? ServerPort { get; set; }
        /// <summary>
        /// The source port for this request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "source_port")]
        public int? SourcePort { get; set; }
        /// <summary>
        /// Total time taken to process the Oauth Subrequest. This is the time taken from the 1st byte of the request sent to the
        /// last byte of the response received. Field introduced in 21.1.3. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "total_time")]
        public long? TotalTime { get; set; }
        /// <summary>
        /// The URI path of the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uri_path")]
        public string? UriPath { get; set; }
        /// <summary>
        /// The URI query of the sub-request. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uri_query")]
        public string? UriQuery { get; set; }
    }
}
