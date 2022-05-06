using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVISetvNicNwReqType
    {
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// Unique object identifier of dc.
        /// </summary>
        [JsonProperty(PropertyName = "dc_uuid")]
        public string? DcUuid { get; set; }
        /// <summary>
        /// rm_cookie of VISetvNicNwReq.
        /// </summary>
        [JsonProperty(PropertyName = "rm_cookie")]
        public string? RmCookie { get; set; }
        /// <summary>
        /// Unique object identifier of sevm.
        /// </summary>
        [JsonProperty(PropertyName = "sevm_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SevmUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_admin of obj type VISetvNicNwReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_admin")]
        public NSXTALBVIAdminCredentialsType VcenterAdmin { get; set; }
        /// <summary>
        /// vcenter_sevm_mor of VISetvNicNwReq.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_sevm_mor")]
        public string? VcenterSevmMor { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_vnic_info of obj type VISetvNicNwReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vnic_info")]
        public IList<NSXTALBVIVmVnicInfoType> VcenterVnicInfo { get; set; }
    }
}
