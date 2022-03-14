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
    public class NSXTALBClusterNodeType 
    {
        /// <summary>
        /// Optional service categories that a node can be assigned (e.g. SYSTEM, INFRASTRUCTURE or ANALYTICS). Field introduced in
        /// 18.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }
        /// <summary>
        /// IP address of controller VM.
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// Name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The password we will use when authenticating with this node (Not persisted). Field introduced in 18.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Public IP address or hostname of the controller VM. Field introduced in 17.2.3.
        /// </summary>
        [JsonProperty(PropertyName = "public_ip_or_name")]
        public NSXTALBIpAddrType PublicIpOrName { get; set; }
        /// <summary>
        /// Hostname assigned to this controller VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm_hostname")]
        public string? VmHostname { get; set; }
        /// <summary>
        /// Managed object reference of this controller VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm_mor")]
        public string? VmMor { get; set; }
        /// <summary>
        /// Name of the controller VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm_name")]
        public string? VmName { get; set; }
        /// <summary>
        /// UUID on the controller VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm_uuid")]
        public string? VmUuid { get; set; }
    }
}
