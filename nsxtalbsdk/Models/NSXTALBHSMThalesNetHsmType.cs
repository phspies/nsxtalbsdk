using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBHSMThalesNetHsmType
    {
        /// <summary>
        /// Electronic serial number of the netHSM device. Use Thales anonkneti utility to find the netHSM ESN.
        /// </summary>
        [JsonProperty(PropertyName = "esn")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Esn { get; set; }
        /// <summary>
        /// Hash of the key that netHSM device uses to authenticate itself. Use Thales anonkneti utility to find the netHSM keyhash.
        /// </summary>
        [JsonProperty(PropertyName = "keyhash")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Keyhash { get; set; }
        /// <summary>
        /// Local module id of the netHSM device.
        /// </summary>
        [JsonProperty(PropertyName = "module_id")]
        public int? ModuleId { get; set; }
        /// <summary>
        /// Priority class of the nethsm in an high availability setup. 1 is the highest priority and 100 is the lowest priority.
        /// Allowed values are 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        [System.ComponentModel.DataAnnotations.Required]
        public int Priority { get; set; }
        /// <summary>
        /// IP address of the netHSM device.
        /// </summary>
        [JsonProperty(PropertyName = "remote_ip")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBIpAddrType RemoteIp { get; set; }
        /// <summary>
        /// Port at which the netHSM device accepts the connection. Allowed values are 1-65535.
        /// </summary>
        [JsonProperty(PropertyName = "remote_port")]
        public int? RemotePort { get; set; }
    }
}
