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
    public class NSXTALBPersistenceFilterType 
    {
        /// <summary>
        /// Persistence cookie.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_cookie")]
        public string? PersistenceCookie { get; set; }
        /// <summary>
        /// Placeholder for description of property persistence_end_ip of obj type PersistenceFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "persistence_end_ip")]
        public NSXTALBIpAddrType PersistenceEndIp { get; set; }
        /// <summary>
        /// Placeholder for description of property persistence_ip of obj type PersistenceFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "persistence_ip")]
        public NSXTALBIpAddrType PersistenceIp { get; set; }
        /// <summary>
        /// Number of persistence_mask.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_mask")]
        public int? PersistenceMask { get; set; }
        /// <summary>
        /// Placeholder for description of property server_end_ip of obj type PersistenceFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "server_end_ip")]
        public NSXTALBIpAddrType ServerEndIp { get; set; }
        /// <summary>
        /// Placeholder for description of property server_ip of obj type PersistenceFilter field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "server_ip")]
        public NSXTALBIpAddrType ServerIp { get; set; }
        /// <summary>
        /// Number of server_mask.
        /// </summary>
        [JsonProperty(PropertyName = "server_mask")]
        public int? ServerMask { get; set; }
        /// <summary>
        /// Number of server_port.
        /// </summary>
        [JsonProperty(PropertyName = "server_port")]
        public int? ServerPort { get; set; }
    }
}
