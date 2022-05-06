using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHTTP2PoolPropertiesType
    {
        /// <summary>
        /// The max number of control frames that server can send over an HTTP/2 connection. '0' means unlimited. Allowed values are
        /// 0-10000. Special values are 0- Unlimited control frames on a server side HTTP/2 connection. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_control_frames_per_connection")]
        public int? MaxHttp2ControlFramesPerConnection { get; set; }
        /// <summary>
        /// The maximum size in bytes of the compressed request header field. The limit applies equally to both name and value.
        /// Allowed values are 1-8192. Field introduced in 21.1.1. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "max_http2_header_field_size")]
        public int? MaxHttp2HeaderFieldSize { get; set; }
    }
}
