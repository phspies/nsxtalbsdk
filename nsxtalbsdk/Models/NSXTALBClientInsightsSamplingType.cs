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
    public class NSXTALBClientInsightsSamplingType 
    {
        /// <summary>
        /// Client IP addresses to check when inserting RUM script.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        public NSXTALBIpAddrMatchType ClientIp { get; set; }
        /// <summary>
        /// URL patterns to check when inserting RUM script.
        /// </summary>
        [JsonProperty(PropertyName = "sample_uris")]
        public NSXTALBStringMatchType SampleUris { get; set; }
        /// <summary>
        /// URL patterns to avoid when inserting RUM script.
        /// </summary>
        [JsonProperty(PropertyName = "skip_uris")]
        public NSXTALBStringMatchType SkipUris { get; set; }
    }
}
