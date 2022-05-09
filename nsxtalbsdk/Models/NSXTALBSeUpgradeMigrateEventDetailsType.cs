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
    public class NSXTALBSeUpgradeMigrateEventDetailsType 
    {
        /// <summary>
        /// Placeholder for description of property migrate_params of obj type SeUpgradeMigrateEventDetails field type str  type
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
