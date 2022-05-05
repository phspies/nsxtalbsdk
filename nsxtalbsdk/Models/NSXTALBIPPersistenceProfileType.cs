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
    public class NSXTALBIPPersistenceProfileType 
    {
        /// <summary>
        /// Mask to be applied on client IP. This may be used to persist clients from a subnet to the same server. When set to 0,
        /// all requests are sent to the same server. Allowed values are 0-128. Field introduced in 18.2.7. Allowed in Basic
        /// edition, Essentials edition, Enterprise edition.
        /// </summary>
        [JsonProperty(PropertyName = "ip_mask")]
        public int? IpMask { get; set; }
        /// <summary>
        /// The length of time after a client's connections have closed before expiring the client's persistence to a server.
        /// Allowed values are 1-720. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "ip_persistent_timeout")]
        public int? IpPersistentTimeout { get; set; }
    }
}
