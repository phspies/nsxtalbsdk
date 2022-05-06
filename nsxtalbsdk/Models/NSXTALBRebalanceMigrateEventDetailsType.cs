using Newtonsoft.Json;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBRebalanceMigrateEventDetailsType
    {
        /// <summary>
        /// Placeholder for description of property migrate_params of obj type RebalanceMigrateEventDetails field type str  type
        /// object
        /// </summary>
        [JsonProperty(PropertyName = "migrate_params")]
        public NSXTALBVsMigrateParamsType MigrateParams { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VsUuid { get; set; }
    }
}
