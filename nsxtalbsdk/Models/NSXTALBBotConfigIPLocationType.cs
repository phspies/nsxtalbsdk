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
    public class NSXTALBBotConfigIPLocationType 
    {
        /// <summary>
        /// If this is enabled, IP location information is used to determine if a client is a known search engine bot, comes from
        /// the cloud, etc. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The UUID of the Geo-IP database to use. It is a reference to an object of type GeoDB. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "ip_location_db_ref")]
        public string? IpLocationDbRef { get; set; }
        /// <summary>
        /// The system-defined cloud providers. It is a reference to an object of type StringGroup. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "system_cloud_providers_ref")]
        public string? SystemCloudProvidersRef { get; set; }
        /// <summary>
        /// The system-defined search engines. It is a reference to an object of type StringGroup. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "system_search_engines_ref")]
        public string? SystemSearchEnginesRef { get; set; }
    }
}
