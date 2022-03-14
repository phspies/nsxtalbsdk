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
    public class NSXTALBObjectAccessMatchTargetType 
    {
        public NSXTALBObjectAccessMatchTargetType()
        {
        }
        /// <summary>
        /// Key of the label to be matched. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "label_key", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string LabelKey { get; set; }
        /// <summary>
        /// Label values that result in a successful match. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "label_values", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> LabelValues { get; set; }
    }
}
