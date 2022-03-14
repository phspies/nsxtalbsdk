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
    public class NSXTALBSePersistenceEventDetailsType 
    {
        public NSXTALBSePersistenceEventDetailsType()
        {
        }
        /// <summary>
        /// Current number of entries in the client ip persistence table.
        /// </summary>
        [JsonProperty(PropertyName = "entries")]
        public int? Entries { get; set; }
        /// <summary>
        /// Name of pool whose persistence table limits were reached. It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string? Pool { get; set; }
        /// <summary>
        /// Type of persistence. Enum options - PERSISTENCE_TYPE_CLIENT_IP_ADDRESS, PERSISTENCE_TYPE_HTTP_COOKIE,
        /// PERSISTENCE_TYPE_TLS, PERSISTENCE_TYPE_CLIENT_IPV6_ADDRESS, PERSISTENCE_TYPE_CUSTOM_HTTP_HEADER,
        /// PERSISTENCE_TYPE_APP_COOKIE, PERSISTENCE_TYPE_GSLB_SITE.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
    }
}
