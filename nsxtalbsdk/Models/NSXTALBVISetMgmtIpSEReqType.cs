using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBVISetMgmtIpSEReqType
    {
        /// <summary>
        /// Placeholder for description of property admin of obj type VISetMgmtIpSEReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "admin")]
        public NSXTALBVIAdminCredentialsType Admin { get; set; }
        /// <summary>
        /// Placeholder for description of property all_vnic_connected of obj type VISetMgmtIpSEReq field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "all_vnic_connected")]
        public bool? AllVnicConnected { get; set; }
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
        /// Placeholder for description of property ip_params of obj type VISetMgmtIpSEReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "ip_params")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBVISeVmIpConfParamsType IpParams { get; set; }
        /// <summary>
        /// Placeholder for description of property power_on of obj type VISetMgmtIpSEReq field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "power_on")]
        public bool? PowerOn { get; set; }
        /// <summary>
        /// rm_cookie of VISetMgmtIpSEReq.
        /// </summary>
        [JsonProperty(PropertyName = "rm_cookie")]
        public string? RmCookie { get; set; }
        /// <summary>
        /// Unique object identifier of sevm.
        /// </summary>
        [JsonProperty(PropertyName = "sevm_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string SevmUuid { get; set; }
    }
}
