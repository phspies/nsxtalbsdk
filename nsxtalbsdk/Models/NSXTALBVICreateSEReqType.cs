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
    public class NSXTALBVICreateSEReqType 
    {
        /// <summary>
        /// Unique object identifier of cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_uuid")]
        public string? CloudUuid { get; set; }
        /// <summary>
        /// cookie of VICreateSEReq.
        /// </summary>
        [JsonProperty(PropertyName = "cookie")]
        public string? Cookie { get; set; }
        /// <summary>
        /// Unique object identifier of se_grp.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_uuid")]
        public string? SeGrpUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property se_params of obj type VICreateSEReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "se_params")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTALBVISeVmOvaParamsType SeParams { get; set; }
        /// <summary>
        /// Unique object identifier of tenant.
        /// </summary>
        [JsonProperty(PropertyName = "tenant_uuid")]
        public string? TenantUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_admin of obj type VICreateSEReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_admin")]
        public NSXTALBVIAdminCredentialsType VcenterAdmin { get; set; }
        /// <summary>
        /// vcenter_vnic_portgroups of VICreateSEReq.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_vnic_portgroups")]
        public IList<string> VcenterVnicPortgroups { get; set; }
    }
}
