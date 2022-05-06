using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVIDeleteSEReqType
    {
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// Unique object identifier of segroup.
        /// </summary>
        [JsonProperty(PropertyName = "segroup_uuid")]
        public string? SegroupUuid { get; set; }
        /// <summary>
        /// Unique object identifier of sevm.
        /// </summary>
        [JsonProperty(PropertyName = "sevm_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SevmUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_admin of obj type VIDeleteSEReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_admin")]
        public NSXTALBVIAdminCredentialsType VcenterAdmin { get; set; }
    }
}
