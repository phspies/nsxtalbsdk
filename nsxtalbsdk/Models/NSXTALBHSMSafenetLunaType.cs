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
    public class NSXTALBHSMSafenetLunaType 
    {
        /// <summary>
        /// Group Number of generated HA Group.
        /// </summary>
        [JsonProperty(PropertyName = "ha_group_num")]
        public long? HaGroupNum { get; set; }
        /// <summary>
        /// Set to indicate HA across more than one servers.
        /// </summary>
        [JsonProperty(PropertyName = "is_ha")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool IsHa { get; set; }
        /// <summary>
        /// Node specific information.
        /// </summary>
        [JsonProperty(PropertyName = "node_info")]
        public IList<NSXTALBHSMSafenetClientInfoType> NodeInfo { get; set; }
        /// <summary>
        /// SafeNet/Gemalto HSM Servers used for crypto operations.
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public IList<NSXTALBHSMSafenetLunaServerType> Server { get; set; }
        /// <summary>
        /// Generated File - server.pem.
        /// </summary>
        [JsonProperty(PropertyName = "server_pem")]
        public string? ServerPem { get; set; }
        /// <summary>
        /// If enabled, dedicated network is used to communicate with HSM,else, the management network is used.
        /// </summary>
        [JsonProperty(PropertyName = "use_dedicated_network")]
        public bool? UseDedicatedNetwork { get; set; }
    }
}
