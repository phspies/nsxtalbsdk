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
    public class NSXTALBAllSeUpgradeEventDetailsType 
    {
        public NSXTALBAllSeUpgradeEventDetailsType()
        {
        }
        /// <summary>
        /// notes of AllSeUpgradeEventDetails.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public IList<string> Notes { get; set; }
        /// <summary>
        /// Number of num_se.
        /// </summary>
        [JsonProperty(PropertyName = "num_se", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public int NumSe { get; set; }
        /// <summary>
        /// Number of num_vs.
        /// </summary>
        [JsonProperty(PropertyName = "num_vs")]
        public int? NumVs { get; set; }
        /// <summary>
        /// Placeholder for description of property request of obj type AllSeUpgradeEventDetails field type str  type object
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public NSXTALBSeUpgradeParamsType Request { get; set; }
    }
}
