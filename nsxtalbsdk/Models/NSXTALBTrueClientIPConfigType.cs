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
    public class NSXTALBTrueClientIPConfigType 
    {
        /// <summary>
        /// Denotes the end from which to count the IPs in the specified header value. Enum options - LEFT, RIGHT. Field introduced
        /// in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string? Direction { get; set; }
        /// <summary>
        /// Headers to derive client IP from. The header value needs to be a comma-separated list of IP addresses. If none specified
        /// and use_true_client_ip is set to true, it will use X-Forwarded-For header, if present. Field introduced in 21.1.3.
        /// Maximum of 1 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<string> Headers { get; set; }
        /// <summary>
        /// Position in the configured direction, in the specified header's value, to be used to set true client IP. If the value is
        /// greater than the number of IP addresses in the header, then the last IP address in the configured direction in the
        /// header will be used. Allowed values are 1-1000. Field introduced in 21.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "index_in_header")]
        public int? IndexInHeader { get; set; }
    }
}
