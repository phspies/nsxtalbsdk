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
    public class NSXTALBHTTP2ApplicationProfileType 
    {
        /// <summary>
        /// The initial flow control window size in KB for HTTP/2 streams. Allowed values are 64-32768. Field introduced in 18.2.10,
        /// 20.1.1. Unit is KB.
        /// </summary>
        [JsonProperty(PropertyName = "http2_initial_window_size")]
        public int? Http2InitialWindowSize { get; set; }
        /// <summary>
        /// The max number of concurrent streams over a client side HTTP/2 connection. Allowed values are 1-256. Field introduced in
        /// 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_concurrent_streams_per_connection")]
        public int? MaxHttp2ConcurrentStreamsPerConnection { get; set; }
        /// <summary>
        /// The max number of control frames that client can send over an HTTP/2 connection. '0' means unlimited. Allowed values are
        /// 0-10000. Special values are 0- Unlimited control frames on a client side HTTP/2 connection. Field introduced in 18.2.10,
        /// 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_control_frames_per_connection")]
        public int? MaxHttp2ControlFramesPerConnection { get; set; }
        /// <summary>
        /// The max number of empty data frames that client can send over an HTTP/2 connection. '0' means unlimited. Allowed values
        /// are 0-10000. Special values are 0- Unlimited empty data frames over a client side HTTP/2 connection. Field introduced in
        /// 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_empty_data_frames_per_connection")]
        public int? MaxHttp2EmptyDataFramesPerConnection { get; set; }
        /// <summary>
        /// The maximum size in bytes of the compressed request header field. The limit applies equally to both name and value.
        /// Allowed values are 1-8192. Field introduced in 18.2.10, 20.1.1. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_header_field_size")]
        public int? MaxHttp2HeaderFieldSize { get; set; }
        /// <summary>
        /// The max number of frames that can be queued waiting to be sent over a client side HTTP/2 connection at any given time.
        /// '0' means unlimited. Allowed values are 0-10000. Special values are 0- Unlimited frames can be queued on a client side
        /// HTTP/2 connection. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_queued_frames_to_client_per_connection")]
        public int? MaxHttp2QueuedFramesToClientPerConnection { get; set; }
        /// <summary>
        /// The maximum number of requests over a client side HTTP/2 connection. Allowed values are 0-10000. Special values are 0-
        /// Unlimited requests on a client side HTTP/2 connection. Field introduced in 18.2.10, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_requests_per_connection")]
        public int? MaxHttp2RequestsPerConnection { get; set; }
    }
}
