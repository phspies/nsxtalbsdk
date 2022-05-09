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
    public class NSXTALBAppCookiePersistenceProfileType 
    {
        /// <summary>
        /// Key to use for cookie encryption.
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key")]
        public string? EncryptionKey { get; set; }
        /// <summary>
        /// Header or cookie name for application cookie persistence.
        /// </summary>
        [JsonProperty(PropertyName = "prst_hdr_name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PrstHdrName { get; set; }
        /// <summary>
        /// The length of time after a client's connections have closed before expiring the client's persistence to a server.
        /// Allowed values are 1-720. Unit is MIN.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }
    }
}
