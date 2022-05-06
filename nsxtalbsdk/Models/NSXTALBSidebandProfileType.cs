using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBSidebandProfileType
    {
        /// <summary>
        /// IP Address of the sideband server.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public IList<NSXTALBIpAddrType> Ip { get; set; }
        /// <summary>
        /// Maximum size of the request body that will be sent on the sideband. Allowed values are 0-16384. Unit is BYTES.
        /// </summary>
        [JsonProperty(PropertyName = "sideband_max_request_body_size")]
        public int? SidebandMaxRequestBodySize { get; set; }
    }
}
