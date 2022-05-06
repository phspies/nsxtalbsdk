using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBDSRequestLogType
    {
        /// <summary>
        /// Name of the DataScript where this request was called. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "ds_name")]
        public string? DsName { get; set; }
        /// <summary>
        /// DataScript event where out-of-band request was sent. Enum options - VS_DATASCRIPT_EVT_HTTP_REQ,
        /// VS_DATASCRIPT_EVT_HTTP_RESP, VS_DATASCRIPT_EVT_HTTP_RESP_DATA, VS_DATASCRIPT_EVT_HTTP_LB_FAILED,
        /// VS_DATASCRIPT_EVT_HTTP_REQ_DATA, VS_DATASCRIPT_EVT_HTTP_RESP_FAILED, VS_DATASCRIPT_EVT_HTTP_LB_DONE,
        /// VS_DATASCRIPT_EVT_HTTP_AUTH, VS_DATASCRIPT_EVT_HTTP_POST_AUTH, VS_DATASCRIPT_EVT_TCP_CLIENT_ACCEPT,
        /// VS_DATASCRIPT_EVT_SSL_HANDSHAKE_DONE, VS_DATASCRIPT_EVT_CLIENT_SSL_PRE_CONNECT,
        /// VS_DATASCRIPT_EVT_CLIENT_SSL_CLIENT_HELLO, VS_DATASCRIPT_EVT_DNS_REQ, VS_DATASCRIPT_EVT_DNS_RESP,
        /// VS_DATASCRIPT_EVT_L4_REQUEST, VS_DATASCRIPT_EVT_L4_RESPONSE, VS_DATASCRIPT_EVT_MAX. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public string? Event { get; set; }
        /// <summary>
        /// Response headers received from the server. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "headers_received_from_server")]
        public string? HeadersReceivedFromServer { get; set; }
        /// <summary>
        /// Request headers sent to the server. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "headers_sent_to_server")]
        public string? HeadersSentToServer { get; set; }
        /// <summary>
        /// The HTTP response code received from the external server. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "http_response_code")]
        public int? HttpResponseCode { get; set; }
        /// <summary>
        /// The HTTP version of the out-of-band request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "http_version")]
        public string? HttpVersion { get; set; }
        /// <summary>
        /// The HTTP method of the out-of-band request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string? Method { get; set; }
        /// <summary>
        /// The name of the pool that was used for the request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// The uuid of the pool that was used for the request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_uuid")]
        public string? PoolUuid { get; set; }
        /// <summary>
        /// Length of the request sent in bytes. Field introduced in 20.1.3. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "request_length")]
        public long? RequestLength { get; set; }
        /// <summary>
        /// Length of the response received in bytes. Field introduced in 20.1.3. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "response_length")]
        public long? ResponseLength { get; set; }
        /// <summary>
        /// The IP of the server that was used for the request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public int? ServerIp { get; set; }
        /// <summary>
        /// The name of the server that was used for the request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        public string? ServerName { get; set; }
        /// <summary>
        /// The port of the server that was used for the request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_port")]
        public int? ServerPort { get; set; }
        /// <summary>
        /// Number of servers tried during server reselect before the response is sent back. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "servers_tried")]
        public int? ServersTried { get; set; }
        /// <summary>
        /// The source port for this request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "source_port")]
        public int? SourcePort { get; set; }
        /// <summary>
        /// Total time taken to process the Out-of-Band request. This is the time taken from the 1st byte of the request sent to the
        /// last byte of the response received. Field introduced in 20.1.3. Unit is MILLISECONDS.
        /// </summary>
        [JsonProperty(PropertyName = "total_time")]
        public long? TotalTime { get; set; }
        /// <summary>
        /// The URI path of the out-of-band request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uri_path")]
        public string? UriPath { get; set; }
        /// <summary>
        /// The URI query of the out-of-band request. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "uri_query")]
        public string? UriQuery { get; set; }
    }
}
