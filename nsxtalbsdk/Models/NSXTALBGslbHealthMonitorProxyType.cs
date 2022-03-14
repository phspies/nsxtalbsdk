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
    public class NSXTALBGslbHealthMonitorProxyType 
    {
        public NSXTALBGslbHealthMonitorProxyType()
        {
        }
        /// <summary>
        /// This field identifies the health monitor proxy behavior. The designated site for health monitor proxy can monitor public
        /// or private or all the members of a given site. . Enum options - GSLB_HEALTH_MONITOR_PROXY_ALL_MEMBERS,
        /// GSLB_HEALTH_MONITOR_PROXY_PRIVATE_MEMBERS. Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_type")]
        public string? ProxyType { get; set; }
        /// <summary>
        /// This field identifies the site that will health monitor on behalf of the current site. i.e. it will be a health monitor
        /// proxy and monitor members of the current site. . Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "site_uuid")]
        public string? SiteUuid { get; set; }
    }
}
