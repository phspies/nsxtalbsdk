using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
namespace nsxtalbsdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NSXTALBObjectAccessMatchTargetType
    {
        /// <summary>
        /// Key of the label to be matched. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "label_key")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LabelKey { get; set; }
        /// <summary>
        /// Label values that result in a successful match. Field introduced in 18.2.7, 20.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "label_values")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> LabelValues { get; set; }
    }
}
