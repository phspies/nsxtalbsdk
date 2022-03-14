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
    public class NSXTALBVIDeleteSEReqType 
    {
        public NSXTALBVIDeleteSEReqType()
        {
        }
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
        [JsonProperty(PropertyName = "sevm_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SevmUuid { get; set; }
        /// <summary>
        /// Placeholder for description of property vcenter_admin of obj type VIDeleteSEReq field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "vcenter_admin")]
        public NSXTALBVIAdminCredentialsType VcenterAdmin { get; set; }
    }
}
