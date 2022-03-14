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
    public class NSXTALBSeThreshEventDetailsType 
    {
        /// <summary>
        /// Number of curr_value.
        /// </summary>
        [JsonProperty(PropertyName = "curr_value", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public long CurrValue { get; set; }
        /// <summary>
        /// Number of thresh.
        /// </summary>
        [JsonProperty(PropertyName = "thresh", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public long Thresh { get; set; }
    }
}
