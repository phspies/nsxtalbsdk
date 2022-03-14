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
    public class NSXTALBGslbServiceDownResponseType 
    {
        public NSXTALBGslbServiceDownResponseType()
        {
        }
        /// <summary>
        /// Fallback IP address to use in A response to the client query when the GSLB service is DOWN.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_ip")]
        public NSXTALBIpAddrType FallbackIp { get; set; }
        /// <summary>
        /// Fallback IPV6 address to use in AAAA response to the client query when the GSLB service is DOWN. Field introduced in
        /// 18.2.8.
        /// </summary>
        [JsonProperty(PropertyName = "fallback_ip6")]
        public NSXTALBIpAddrType FallbackIp6 { get; set; }
        /// <summary>
        /// Response from DNS service towards the client when the GSLB service is DOWN. Enum options -
        /// GSLB_SERVICE_DOWN_RESPONSE_NONE, GSLB_SERVICE_DOWN_RESPONSE_ALL_RECORDS, GSLB_SERVICE_DOWN_RESPONSE_FALLBACK_IP,
        /// GSLB_SERVICE_DOWN_RESPONSE_EMPTY.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
