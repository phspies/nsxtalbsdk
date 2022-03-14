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
    public class NSXTALBVinfraMgmtNwChangeDetailsType 
    {
        public NSXTALBVinfraMgmtNwChangeDetailsType()
        {
        }
        /// <summary>
        /// existing_nw of VinfraMgmtNwChangeDetails.
        /// </summary>
        [JsonProperty(PropertyName = "existing_nw", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string ExistingNw { get; set; }
        /// <summary>
        /// new_nw of VinfraMgmtNwChangeDetails.
        /// </summary>
        [JsonProperty(PropertyName = "new_nw", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string NewNw { get; set; }
        /// <summary>
        /// vcenter of VinfraMgmtNwChangeDetails.
        /// </summary>
        [JsonProperty(PropertyName = "vcenter", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Vcenter { get; set; }
    }
}
