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
    public class NSXTALBVsMigrateParamsType 
    {
        public NSXTALBVsMigrateParamsType()
        {
        }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "from_se_ref")]
        public string? FromSeRef { get; set; }
        /// <summary>
        /// Number of new_vcpus.
        /// </summary>
        [JsonProperty(PropertyName = "new_vcpus")]
        public int? NewVcpus { get; set; }
        /// <summary>
        /// It is a reference to an object of type VIMgrHostRuntime.
        /// </summary>
        [JsonProperty(PropertyName = "to_host_ref")]
        public string? ToHostRef { get; set; }
        /// <summary>
        /// Placeholder for description of property to_new_se of obj type VsMigrateParams field type str  type boolean
        /// </summary>
        [JsonProperty(PropertyName = "to_new_se")]
        public bool? ToNewSe { get; set; }
        /// <summary>
        /// It is a reference to an object of type ServiceEngine.
        /// </summary>
        [JsonProperty(PropertyName = "to_se_ref")]
        public string? ToSeRef { get; set; }
        /// <summary>
        /// Unique object identifier of the object.
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// Field introduced in 17.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "vip_id", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string VipId { get; set; }
    }
}
