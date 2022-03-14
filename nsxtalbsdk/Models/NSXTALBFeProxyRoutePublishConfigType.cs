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
    public class NSXTALBFeProxyRoutePublishConfigType 
    {
        public NSXTALBFeProxyRoutePublishConfigType()
        {
        }
        /// <summary>
        /// Publish ECMP route to upstream router for VIP. Enum options - FE_PROXY_ROUTE_PUBLISH_NONE,
        /// FE_PROXY_ROUTE_PUBLISH_QUAGGA_WEBAPP.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Listener port for publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher_port")]
        public int? PublisherPort { get; set; }
        /// <summary>
        /// Subnet for publisher.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public int? Subnet { get; set; }
        /// <summary>
        /// Token for tracking changes.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }
    }
}
