using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIVmVnicInfoType
    {
        /// <summary>
        /// mac_addr of VIVmVnicInfo.
        /// </summary>
        [JsonProperty(PropertyName = "mac_addr")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddr { get; set; }
        /// <summary>
        /// vcenter_portgroup of VIVmVnicInfo.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_portgroup")]
        public string? VcenterPortgroup { get; set; }
        /// <summary>
        /// Enum options - VNIC_VSWITCH, VNIC_DVS.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vnic_nw")]
        public string? VcenterVnicNw { get; set; }
    }
}
