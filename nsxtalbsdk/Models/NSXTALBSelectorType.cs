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
    public class NSXTALBSelectorType 
    {
        /// <summary>
        /// Labels as key value pairs to select on. Field introduced in 20.1.3. Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<NSXTALBKeyValueTupleType> Labels { get; set; }
        /// <summary>
        /// Selector type. Enum options - SELECTOR_IPAM. Field introduced in 20.1.3.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Type { get; set; }
    }
}
