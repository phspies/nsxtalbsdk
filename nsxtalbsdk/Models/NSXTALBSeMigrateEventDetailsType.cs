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
    public class NSXTALBSeMigrateEventDetailsType 
    {
        public NSXTALBSeMigrateEventDetailsType()
        {
        }
        /// <summary>
        /// Number of num_vs.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs")]
        public int? NumVs { get; set; }
        /// <summary>
        /// reason of SeMigrateEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public IList<string> Reason { get; set; }
        /// <summary>
        /// se_name of SeMigrateEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "se_name")]
        public string? SeName { get; set; }
        /// <summary>
        /// Unique object identifier of se.
        /// </summary>
        [JsonProperty(PropertyName = "se_uuid", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string SeUuid { get; set; }
        /// <summary>
        /// vs_name of SeMigrateEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vs_name")]
        public string? VsName { get; set; }
        /// <summary>
        /// Unique object identifier of vs.
        /// </summary>
        [JsonProperty(PropertyName = "vs_uuid")]
        public string? VsUuid { get; set; }
    }
}
