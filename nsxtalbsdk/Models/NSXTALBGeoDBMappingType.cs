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
    public class NSXTALBGeoDBMappingType 
    {
        /// <summary>
        /// Description of the mapping. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The set of mapping elements. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "elements")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTALBGeoDBMappingElementType> Elements { get; set; }
        /// <summary>
        /// The unique name of the user mapping. Field introduced in 21.1.1.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
