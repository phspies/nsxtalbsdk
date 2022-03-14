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
    public class NSXTALBAlertFilterType 
    {
        public NSXTALBAlertFilterType()
        {
        }
        /// <summary>
        /// filter_action of AlertFilter.
        /// </summary>
        [JsonProperty(PropertyName = "filter_action")]
        public string? FilterAction { get; set; }
        /// <summary>
        /// filter_string of AlertFilter.
        /// </summary>
        [JsonProperty(PropertyName = "filter_string", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string FilterString { get; set; }
    }
}
