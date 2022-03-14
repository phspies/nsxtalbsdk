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
    public class NSXTALBOpenStackVnicChangeType 
    {
        /// <summary>
        /// error_string of OpenStackVnicChange.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// mac_addrs of OpenStackVnicChange.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addrs")]
        public IList<string> MacAddrs { get; set; }
        /// <summary>
        /// networks of OpenStackVnicChange.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// Unique object identifier of se_vm.
        /// </summary>
        [JsonProperty(PropertyName = "se_vm_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeVmUuid { get; set; }
    }
}
