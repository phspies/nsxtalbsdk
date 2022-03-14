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
    public class NSXTALBSeIpRemovedEventDetailsType 
    {
        /// <summary>
        /// Vnic name.
        /// </summary>
        [JsonProperty(PropertyName = "if_name")]
        public string? IfName { get; set; }
        /// <summary>
        /// IP added.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public string? Ip { get; set; }
        /// <summary>
        /// Vnic linux name.
        /// </summary>
        [JsonProperty(PropertyName = "linux_name")]
        public string? LinuxName { get; set; }
        /// <summary>
        /// Mac Address.
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// Mask .
        /// </summary>
        [JsonProperty(PropertyName = "mask")]
        public int? Mask { get; set; }
        /// <summary>
        /// DCHP or Static.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }
        /// <summary>
        /// Network UUID.
        /// </summary>
        [JsonProperty(PropertyName = "network_uuid")]
        public string? NetworkUuid { get; set; }
        /// <summary>
        /// Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "ns")]
        public string? Ns { get; set; }
        /// <summary>
        /// UUID of the SE responsible for this event. It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "se_ref")]
        public string? SeRef { get; set; }
    }
}
