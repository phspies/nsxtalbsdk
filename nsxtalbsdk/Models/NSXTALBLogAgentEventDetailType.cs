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
    public class NSXTALBLogAgentEventDetailType 
    {
        public NSXTALBLogAgentEventDetailType()
        {
        }
        /// <summary>
        /// Protocol used for communication to the external entity. Enum options - TCP_CONN. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Protocol { get; set; }
        /// <summary>
        /// Event details for TCP connection event. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_detail")]
        public NSXTALBLogAgentTCPClientEventDetailType TcpDetail { get; set; }
        /// <summary>
        /// Type of log agent event. Enum options - LOG_AGENT_CONNECTION_ERROR. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
