using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBPaaRequestLogType
    {
        /// <summary>
        /// Response headers received from PingAccess server. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "headers_received_from_server")]
        public string? HeadersReceivedFromServer { get; set; }
        /// <summary>
        /// Request headers sent to PingAccess server. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "headers_sent_to_server")]
        public string? HeadersSentToServer { get; set; }
        /// <summary>
        /// The http version of the request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "http_version")]
        public string? HttpVersion { get; set; }
        /// <summary>
        /// The http method of the request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string? Method { get; set; }
        /// <summary>
        /// The name of the pool that was used for the request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "pool_name")]
        public string? PoolName { get; set; }
        /// <summary>
        /// The response code received from the PingAccess server. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "response_code")]
        public int? ResponseCode { get; set; }
        /// <summary>
        /// The IP of the server that was sent the request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public int? ServerIp { get; set; }
        /// <summary>
        /// Number of servers tried during server reselect before the response is sent back. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "servers_tried")]
        public int? ServersTried { get; set; }
        /// <summary>
        /// The uri of the request. Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "uri_path")]
        public string? UriPath { get; set; }
    }
}
