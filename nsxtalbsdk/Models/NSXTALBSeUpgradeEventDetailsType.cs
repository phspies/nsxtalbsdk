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
    public class NSXTALBSeUpgradeEventDetailsType 
    {
        public NSXTALBSeUpgradeEventDetailsType()
        {
        }
        /// <summary>
        /// notes of SeUpgradeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public IList<string> Notes { get; set; }
        /// <summary>
        /// Number of num_vs.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs")]
        public int? NumVs { get; set; }
        /// <summary>
        /// Unique object identifier of se_grp.
        /// </summary>
        [JsonProperty(PropertyName = "se_grp_uuid")]
        public string? SeGrpUuid { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeUuid { get; set; }
    }
}
