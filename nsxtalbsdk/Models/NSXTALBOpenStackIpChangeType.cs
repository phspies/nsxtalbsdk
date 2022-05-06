using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBOpenStackIpChangeType
    {
        /// <summary>
        /// error_string of OpenStackIpChange.
        /// </summary>
        [JsonProperty(PropertyName = "error_string")]
        public string? ErrorString { get; set; }
        /// <summary>
        /// Placeholder for description of property ip of obj type OpenStackIpChange field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType Ip { get; set; }
        /// <summary>
        /// mac_addr of OpenStackIpChange.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addr")]
        public string? MacAddr { get; set; }
        /// <summary>
        /// Unique object identifier of port.
        /// </summary>
        [JsonProperty(PropertyName = "port_uuid")]
        public string? PortUuid { get; set; }
        /// <summary>
        /// Unique object identifier of se_vm.
        /// </summary>
        [JsonProperty(PropertyName = "se_vm_uuid")]
        public string? SeVmUuid { get; set; }
    }
}
