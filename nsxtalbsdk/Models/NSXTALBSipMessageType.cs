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
    public class NSXTALBSipMessageType 
    {
        /// <summary>
        /// Contents up to first 128 bytes of a SIP message for which could not be parsed. Field introduced in 17.2.12, 18.1.3,
        /// 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string? Content { get; set; }
        /// <summary>
        /// Indicates if SIP message is received from a client. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "from_client")]
        public bool? FromClient { get; set; }
        /// <summary>
        /// SIP request method string. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string? Method { get; set; }
        /// <summary>
        /// SIP message receive time stamp. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "rcv_timestamp")]
        public long? RcvTimestamp { get; set; }
        /// <summary>
        /// SIP message size before modifications. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "rx_bytes")]
        public int? RxBytes { get; set; }
        /// <summary>
        /// SIP response status string. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// SIP response status code, 2xx response means success. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public int? StatusCode { get; set; }
        /// <summary>
        /// SIP message size post modifications. Field introduced in 17.2.12, 18.1.3, 18.2.1.
        /// </summary>
        [JsonProperty(PropertyName = "tx_bytes")]
        public int? TxBytes { get; set; }
    }
}
